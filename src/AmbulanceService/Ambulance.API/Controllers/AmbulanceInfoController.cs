using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;

using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Ambulance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbulanceInfoController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AmbulanceInfoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync([FromForm] CreateAmbulanceInfoCommand AmbulanceInfo)
        {
            int result = await _mediator.Send(AmbulanceInfo);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<AmbulanceInfo> classes = await _mediator.Send(new GetAllAmbulanceInfoQuery());

            return Ok(classes);
        }

    }
}
