using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries;
using Restaurent.Application.Absreactions.UseCases.Orders.Commands;
using Restaurent.Application.Absreactions.UseCases.Orders.Handler;
using Restaurent.Application.Absreactions.UseCases.Orders.Queries;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.Orders;

namespace Restaurent.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(CreateOrdersCommand AmbulanceInfo)
        {
            int result = await _mediator.Send(AmbulanceInfo);

            return Ok(result);
        }
        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Order> classes = await _mediator.Send(new GetAllOrdersQuery());

            return Ok(classes);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int classId)
        {
            DeleteOrdersCommand @class = new DeleteOrdersCommand()
            {
                Id = classId
            };

            int result = await _mediator.Send(@class);

            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdateOrdersCommand @updateDoctor)
        {
            int result = await _mediator.Send(@updateDoctor);
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int Id)
        {
            GetMORdersByIdQuery @EmrgencyCall = new GetMORdersByIdQuery()
            {
                Id = Id,
            };

            Order result = await _mediator.Send(@EmrgencyCall);

            return Ok(result);
        }
    }
}
