using MediatR;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;
using Restaurant_System.Shared;

namespace Restaurant_System.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand,ProductSh>
    {
        private readonly IContext _context;

        public AddProductHandler(IContext context)
        {
            _context = context;
        }

        public async Task<ProductSh> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.ProductName, request.ActualNumber, request.RequiredNumber, request.Unit);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return new ProductSh
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ActualNumber = product.ActualNumber,
                RequiredNumber = product.RequiredNumber,
                Unit = product.Unit
            };
        }

    }

        public record AddProductCommand(string ProductName, int ActualNumber, int RequiredNumber, string Unit) : IRequest<ProductSh>;
}
