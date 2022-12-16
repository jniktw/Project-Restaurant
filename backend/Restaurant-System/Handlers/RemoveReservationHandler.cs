using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class RemoveReservationHandler : IRequestHandler<RemoveReservationCommand>
    {
        private readonly IContext _context;

        public RemoveReservationHandler(IContext context)
        {
            _context = context;
        }

        public Task<Unit> Handle(RemoveReservationCommand request, CancellationToken cancellationToken)
        {
            _context.Reservations.Where(r => r.ReservationId.Equals(request.ReservationId)).ExecuteDeleteAsync();
            _context.SaveChangesAsync();
            return Unit.Task;
        }
    }

    public record RemoveReservationCommand(int ReservationId) : IRequest;
}