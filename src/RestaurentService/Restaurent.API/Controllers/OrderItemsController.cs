using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries;
using Restaurent.Application.Absreactions.UseCases.OrderItems.Commands.OrderItemsCommand;
using Restaurent.Application.Absreactions.UseCases.OrderItems.Queries;
using Restaurent.Application.Absreactions.UseCases.Orders.Commands;
using Restaurent.Application.Absreactions.UseCases.Orders.Queries;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.OrderItems;
using Restaurent.Domain.Entities.Orders;

namespace Restaurent.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(CreateOrderItemCommand AmbulanceInfo)
        {
            int result = await _mediator.Send(AmbulanceInfo);

            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdateOrderItemCommand @updateDoctor)
        {
            int result = await _mediator.Send(@updateDoctor);
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<OrderItem> classes = await _mediator.Send(new GetAllOrderItemQuery());

            return Ok(classes);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int classId)
        {
            DeleteOrderItemCommand @class = new DeleteOrderItemCommand()
            {
                Id = classId
            };

            int result = await _mediator.Send(@class);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int Id)
        {
            GetOrderItemByIdQuery @EmrgencyCall = new GetOrderItemByIdQuery()
            {
                Id = Id,
            };

            OrderItem result = await _mediator.Send(@EmrgencyCall);

            return Ok(result);
        }

    }
}
