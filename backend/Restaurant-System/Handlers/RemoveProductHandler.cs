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

        public Task<Unit> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.ProductName,request.ActualNumber,request.RequiredNumber,request.Unit);
            _context.Products.Where(t => t.ProductName.Equals(request.ProductName)).ExecuteDeleteAsync();
            _context.SaveChangesAsync();
            return Unit.Task;
        }
    }

    public record RemoveProductCommand(string ProductName, int ActualNumber, int RequiredNumber, string Unit) : IRequest;
}