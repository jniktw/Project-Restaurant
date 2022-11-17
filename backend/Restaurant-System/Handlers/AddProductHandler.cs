using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IContext _context;

        public AddProductHandler(IContext context)
        {
            _context = context;
        }

        public Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                ProductName = request.ProductName,
                ActualNumber = request.ActualNumber,
                Unit = request.Unit,
                RequiredNumber = request.RequiredNumber
            };
            _context.Products.Add(product);
            _context.SaveChangesAsync();
            return Unit.Task;
        }
    }

    public record AddProductCommand(string ProductName, int ActualNumber, int RequiredNumber, string Unit) : IRequest;
}
