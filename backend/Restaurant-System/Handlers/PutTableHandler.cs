using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class UpdateTableHandler : IRequestHandler<UpdateTableCommand>
    {
        private readonly IContext _context;

        public UpdateTableHandler(IContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateTableCommand request, CancellationToken cancellationToken)
        {
            var table = _context.Tables.First(x => x.Id == request.id);
            table.IdRestaurant = request.IdRestaurant;
            table.IdRoom = request.IdRoom;
            table.NumberOfSeats = request.NumberOfSeats;
            table.IsReserved = request.IsReserved;
            
            _context.Tables.Update(table);
            await _context.SaveChangesAsync();
            return await Unit.Task;
        }
    }

    public record UpdateTableCommand(int IdRestaurant, int IdRoom, int NumberOfSeats, bool IsReserved) : IRequest;
}