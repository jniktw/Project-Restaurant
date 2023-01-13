using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_System.DataAcessLayer.Models;
using Restaurant_System.Handlers;
using Restaurant_System.Shared;

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

        public async Task<IEnumerable<ProductSh>> Get()
        {
            return await _mediator.Send(new ListProductListCommand());
        }
        [HttpPost()]

        public async Task<ProductSh> Post([FromBody] AddProductCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete()]
        public async Task Delete([FromBody] RemoveProductCommand command)
        {
            await _mediator.Send(command);
        }
    }
}