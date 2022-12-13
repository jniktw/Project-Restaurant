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
            var table = _context.Tables.First(t => t.TableId == request.TableId);
            table.RestaurantId = request.RestaurantId;
            table.NumberOfSeats = request.NumberOfSeats;
            table.IsReserved = request.IsReserved;
            
            _context.Tables.Update(table);
            await _context.SaveChangesAsync();
            return await Unit.Task;
        }
    }

    public record UpdateTableCommand(int TableId, int RestaurantId, int NumberOfSeats, bool IsReserved) : IRequest;
}