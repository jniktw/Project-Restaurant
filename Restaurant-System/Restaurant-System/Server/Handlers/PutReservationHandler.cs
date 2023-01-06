using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class UpdateReservationHandler : IRequestHandler<UpdateReservationCommand>
    {
        private readonly IContext _context;

        public UpdateReservationHandler(IContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = _context.Reservations.First(r => r.ReservationId == request.ReservationId);
            reservation.ReservationDate = request.ReservationDate;

            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return await Unit.Task;
        }
    }

    public record UpdateReservationCommand(int ReservationId, DateTime ReservationDate) : IRequest;
}