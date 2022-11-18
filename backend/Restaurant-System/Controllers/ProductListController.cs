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
        [HttpPut()]

        public async Task Put([FromBody] UpdateProductCommand command)
        {
            await _mediator.Send(command);
        }
        [HttpGet()]

        public async Task<IEnumerable<Product>> Get()
        {
            return await _mediator.Send(new ListProductListCommand());
        }
        [HttpPost()]

        public async Task Post( [FromBody] AddProductCommand command )
        {
            await _mediator.Send(command);
        }

    }
}