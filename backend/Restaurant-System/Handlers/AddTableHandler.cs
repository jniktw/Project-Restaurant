using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class AddTableHandler : IRequestHandler<AddTableCommand>
    {
        private readonly IContext _context;

        public AddTableHandler(IContext context)
        {
            _context = context;
        }
        
        public Task<Unit> Handle(AddTableCommand request, CancellationToken cancellationToken)
        {
            var table = new Table(request.RestaurantId, request.NumberOfSeats, request.IsReserved);

            // Make check for RestaurantId
            _context.Tables.Add(table);
            _context.SaveChangesAsync();
            return Unit.Task;
        }
    }

    public record AddTableCommand(int IdRestaurant, int IdRoom, int NumberOfSeats, bool IsReserved) : IRequest;
}