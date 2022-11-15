using MediatR;
using Microsoft.EntityFrameworkCore;
using Restaurant_System.DataAcessLayer;
using Restaurant_System.DataAcessLayer.Models;

namespace Restaurant_System.Handlers
{
    public class ListProductListHandler : IRequestHandler<ListProductListCommand,IEnumerable<Product>>
    {
        private readonly IContext _context;

        public ListProductListHandler(IContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(ListProductListCommand request, CancellationToken cancellationToken)
        {
            var productList = await _context.Products.ToArrayAsync();
            if (productList == null)
            {
                return null;
            }

            return productList;
        }
    }

    public record ListProductListCommand : IRequest<IEnumerable<Product>>; 
    public class ListProductResult
    {

    }
}
