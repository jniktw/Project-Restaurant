using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class RemoveProductHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly IContext _context;

        public RemoveProductHandler(IContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await _context.Products.Where(t => t.Id.Equals(request.Id)).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }

    public record RemoveProductCommand(int Id) : IRequest;
}