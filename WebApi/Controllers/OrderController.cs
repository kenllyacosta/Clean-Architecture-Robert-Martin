using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UseCases.CreateOrder;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly IMediator Mediator;
        public OrderController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost("create-order")]
        public Task<int> Post(CreateOrderInputPort inputPort)
        {
            return Mediator.Send(inputPort);
        }
    }
}
