﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class ListTableHandler : IRequestHandler<ListTableCommand,IEnumerable<Table>>
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
            foreach (var table in Table)
            {
                string reservation = "not reserved";
                if (table.IsReserved)
                {
                    reservation = "reserved";
                }
                await file.WriteLineAsync(table.IdTable + " Table in " + table.NumberOfSeats + " seats" + "is " + reservation);
            }
            return Table;
        }
    }

    public record ListTableCommand : IRequest<IEnumerable<Table>>; 
}