
using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class PutProductHandler : IRequestHandler<PutProductCommand>
    {
        private readonly IContext _context;

        public PutProductHandler(IContext context)
        {
            _context = context;
        }

        async Task<Unit> IRequestHandler<PutProductCommand, Unit>.Handle(PutProductCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Products.First(x => x.Id == request.id);
                product.ProductName = request.ProductName;
                product.ActualNumber = request.ActualNumber;
                product.Unit = request.Unit;
                product.RequiredNumber = request.RequiredNumber;
                _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return await Unit.Task;
        }
    }

    public record PutProductCommand(string ProductName, int ActualNumber, int RequiredNumber, string Unit, int id ) : IRequest;
}