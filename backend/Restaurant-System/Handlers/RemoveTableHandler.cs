using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class RemoveTableHandler : IRequestHandler<RemoveTableCommand>
    {
        private readonly IContext _context;

        public RemoveTableHandler(IContext context)
        {
            _context = context;
        }

        public Task<Unit> Handle(RemoveTableCommand request, CancellationToken cancellationToken)
        {
            _context.Tables.Where(t => t.TableId.Equals(request.TableId)).ExecuteDeleteAsync();
            _context.SaveChangesAsync();
            return Unit.Task;
        }
    }

    public record RemoveTableCommand(int TableId) : IRequest;
}