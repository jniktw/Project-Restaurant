
using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IContext _context;

        public UpdateProductHandler(IContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _context.Products.First(x => x.Id == request.Id);
            product.ProductName = request.ProductName;
            product.ActualNumber = request.ActualNumber;
            product.Unit = request.Unit;
            product.RequiredNumber = request.RequiredNumber;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return await Unit.Task;
        }
    }

    public record UpdateProductCommand(int Id,string ProductName, int ActualNumber, int RequiredNumber, string Unit) : IRequest;
}