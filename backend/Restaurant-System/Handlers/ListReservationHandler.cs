using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class ListReservationHandler : IRequestHandler<ListReservationCommand,IEnumerable<Reservation>>
    {
        private readonly IContext _context;

        public ListReservationHandler(IContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reservation>> Handle(ListReservationCommand request, CancellationToken cancellationToken)
        {
            var Reservation = await _context.Reservations.ToArrayAsync();
            
            // if (Reservation == null)
            // {
            //     return null;
            // }
            
            return Reservation;
        }
    }

    public record ListReservationCommand : IRequest<IEnumerable<Reservation>>; 
}