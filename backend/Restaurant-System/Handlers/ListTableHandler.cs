using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class ListTableHandler : IRequestHandler<ListTableCommand,IEnumerable<Product>>
    {
        private readonly IContext _context;

        public ListTableHandler(IContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Table>> Handle(ListTableCommand request, CancellationToken cancellationToken)
        {
            var Table = await _context.Tables.ToArrayAsync();
            if (Table == null)
            {
                return null;
            }
            using StreamWriter file = new("Table.txt");
            foreach (var table in Table)
            {
                string reservation = "not reserved";
                if (table.IsReserved)
                {
                    reservation = "reserved";
                }
                await file.WriteLineAsync(table.IdTable + " Table in " + table.IdRoom + "room with " + table.NumberOfSeats + " seats" + "is " + reservation);
            }
            return Table;
        }
    }

    public record ListTableCommand : IRequest<IEnumerable<Table>>; 
}