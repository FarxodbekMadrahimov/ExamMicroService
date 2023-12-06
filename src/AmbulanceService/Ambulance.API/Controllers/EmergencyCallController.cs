using Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand;
using Ambulance.Application.UseCases.EmergencyCalls.Queries;
using Ambulance.Application.UseCases.EmergencyCalls.Queries.EmergencyCallQueries;
using Ambulance.Domain.Entitites.EmergencyCalls;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

[ApiController]
[Route("api/[controller]/[action]")]

public class EmergencyCallController : ControllerBase
{
    private readonly IMediator _mediator;

    public EmergencyCallController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync()
    {
        IEnumerable<EmergencyCalling> classes = await _mediator.Send(new GetEmergencyCallQuery());

        return Ok(classes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmergencyCall(CreateEmergencyCallCommnad model)
    {
        var command = new CreateEmergencyCallCommnad
        {
            CallerName = model.CallerName,
            Location = model.Location,
            TimeOfCall = model.TimeOfCall,
            AmbulanceIsDispatched = model.AmbulanceIsDispatched,
            AmbulanceId = model.AmbulanceId,
        };
        await _mediator.Send(command);
        return Ok("Emergency call created successfully");
    }
    [HttpDelete("{id}")]
    public async ValueTask<ActionResult<bool>> DeletePersonAsync(int id)
    {
        var command = new DeleteEmergencyCallCommand()
        {
            Id = id
        };

        bool result = await _mediator.Send(command);

        return Ok(result);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdateEmergencyCallCommand @emergencyCallCommand)
    {
        int result = await _mediator.Send(@emergencyCallCommand);

        return Ok(result);
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetByIdAsync(int Id)
    {
        GetemergencyCallByIdQuery @EmrgencyCall = new GetemergencyCallByIdQuery()
        {
            Id = Id,
        };

        EmergencyCalling result = await _mediator.Send(@EmrgencyCall);

        return Ok(result);
    }
}