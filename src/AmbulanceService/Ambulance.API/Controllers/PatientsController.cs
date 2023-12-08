using Ambulance.Application.UseCases.Patients.Command.PatientCommands;
using Ambulance.Application.UseCases.Patients.Queries.PatientQueries;
using Ambulance.Domain.Entitites.Patients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambulance.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PatientsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync(CreatePatientCommand model)
        {
            int result = await _mediator.Send(model);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Patient> classes = await _mediator.Send(new GetAllPatientsQuery());

            return Ok(classes);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdatePatientCommand @emergencyCallCommand)
        {
            int result = await _mediator.Send(@emergencyCallCommand);

            return Ok(result);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int Id)
        {
            DeletePatientCommand patient = new DeletePatientCommand()
            {
                Id = Id
            };

            int result = await _mediator.Send(patient);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int Id)
        {
            GetPatientByIdQuery @EmrgencyCall = new GetPatientByIdQuery()
            {
                Id = Id,
            };

            Patient result = await _mediator.Send(@EmrgencyCall);

            return Ok(result);
        }
    }
}
