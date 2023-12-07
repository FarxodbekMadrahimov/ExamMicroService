using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
using Ambulance.Application.UseCases.Doctors.Command.DoctorCommands;
using Ambulance.Application.UseCases.Patients.Command.PatientCommands;
using Ambulance.Application.UseCases.Patients.Queries.PatientQueries;
using Ambulance.Domain.Dtos.PatientDtos;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Patients;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ambulance.API.Controllers
{
    [Route("api/[controller]")]
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
    }
}
