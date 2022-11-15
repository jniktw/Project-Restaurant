using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductListController : ControllerBase
    {
        private IMediator mediator;
      
    }
}