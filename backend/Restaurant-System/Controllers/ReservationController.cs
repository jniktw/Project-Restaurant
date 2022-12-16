using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant_System.DataAcessLayer.Models;
using Restaurant_System.Handlers;


namespace Restaurant_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private IMediator _mediator;

        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut()]

        public async Task Put([FromBody] UpdateReservationCommand command)
        {
            await _mediator.Send(command);
        }
        
        [HttpGet()]

        public async Task<IEnumerable<Reservation>> Get()
        {
            return await _mediator.Send(new ListReservationCommand());
        }
        [HttpPost()]

        public async Task Post( [FromBody] AddReservationCommand command )
        {
            await _mediator.Send(command);
        }

        [HttpDelete()]
        public async Task Delete([FromBody] RemoveReservationCommand command)
        {
            await _mediator.Send(command);
        }
    }
}