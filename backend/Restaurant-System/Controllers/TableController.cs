using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_System.DataAcessLayer.Models;
using Restaurant_System.Handlers;


namespace Restaurant_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        private IMediator _mediator;

        public TableController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut()]

        public async Task Put([FromBody] UpdateTableCommand command)
        {
            await _mediator.Send(command);
        }
        
        [HttpGet()]

        public async Task<IEnumerable<Table>> Get()
        {
            return await _mediator.Send(new ListTableCommand());
        }
        [HttpPost()]

        public async Task Post( [FromBody] AddListCommand command )
        {
            await _mediator.Send(command);
        }

        [HttpDelete()]
        public async Task Delete([FromBody] RemoveTableCommand command)
        {
            await _mediator.Send(command);
        }
    }
}