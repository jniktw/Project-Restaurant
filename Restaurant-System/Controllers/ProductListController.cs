using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_System.DataAcessLayer.Models;
using Restaurant_System.Handlers;

namespace Restaurant_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductListController : ControllerBase
    {
        private IMediator _mediator;

        public ProductListController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(Name = "ListCustomers")]

        public async Task<IEnumerable<Product>> Get()
        {
            return await _mediator.Send(new ListProductListCommand());
        }

    }
}