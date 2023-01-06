using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;
namespace Restaurant_System.Handlers
{
    public class AddReservationHandler : IRequestHandler<AddReservationCommand>
    {
        private readonly IContext _context;

        public AddReservationHandler(IContext context)
        {
            _context = context;
        }

        public Task<Unit> Handle(AddReservationCommand request, CancellationToken cancellationToken)
        {
            var Reservation = new Reservation(request.ReservationDate);

            // Make check for RestaurantId
            _context.Reservations.Add(Reservation);
            _context.SaveChangesAsync();
            return Unit.Task;
        }
    }

    public record AddReservationCommand(DateTime ReservationDate) : IRequest;
}