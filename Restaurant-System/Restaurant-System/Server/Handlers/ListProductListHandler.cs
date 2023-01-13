using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;
using Restaurant_System.Shared;

namespace Restaurant_System.Handlers
{
    public class ListProductListHandler : IRequestHandler<ListProductListCommand, IEnumerable<ProductSh>>
    {
        private readonly IContext _context;

        public ListProductListHandler(IContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductSh>> Handle(ListProductListCommand request, CancellationToken cancellationToken)
        {
            var productList = await _context.Products.ToArrayAsync();
            if (productList == null)
            {
                return null;
            }
            using StreamWriter file = new("ProductList.txt");
            foreach (var product in productList)
            {
                await file.WriteLineAsync(product.ProductName + " - " + (product.RequiredNumber - product.ActualNumber) + " " + product.Unit);
            }
            var Table = new List<ProductSh>();
            foreach(var product in productList)
            {
                var productSh = new ProductSh {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    ActualNumber=product.ActualNumber,
                    RequiredNumber = product.RequiredNumber,
                    Unit= product.Unit };
                Table.Add(productSh);
            }
            return Table;
        }
    }

    public record ListProductListCommand : IRequest<IEnumerable<ProductSh>>;
}
