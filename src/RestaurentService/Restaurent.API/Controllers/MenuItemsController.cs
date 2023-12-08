using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Commands.MenuItemsCommand;
using Restaurent.Application.Absreactions.UseCases.MenuItems.Queries.MenuItemsQueries;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.Orders;
using Restaurent.Infrastructures.Persistance;

namespace Restaurent.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync( CreateMenuItemCommand AmbulanceInfo)
        {
            int result = await _mediator.Send(AmbulanceInfo);

            return Ok(result);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<MenuItem> classes = await _mediator.Send(new GetAllMenuItemQuery());

            return Ok(classes);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdateMenuItemCommand @updateDoctor)
        {
            int result = await _mediator.Send(@updateDoctor);
            return Ok(result);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int classId)
        {
            DeleteMenuItemCommand @class = new DeleteMenuItemCommand()
            {
                Id = classId
            };

            int result = await _mediator.Send(@class);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int Id)
        {
            GetMenuItemByIdQuery @EmrgencyCall = new GetMenuItemByIdQuery()
            {
                Id = Id,
            };

            MenuItem result = await _mediator.Send(@EmrgencyCall);

            return Ok(result);
        }

    }
}
