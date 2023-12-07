using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
using Ambulance.Application.UseCases.Doctors.Command.DoctorCommands;
using Ambulance.Application.UseCases.Doctors.Handler.DocotorHandlers;
using Ambulance.Application.UseCases.Doctors.Queries.DoctorQueries;
using Ambulance.Application.UseCases.EmergencyCalls.Queries.EmergencyCallQueries;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Doctors;
using Ambulance.Domain.Entitites.EmergencyCalls;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ambulance.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        
        private readonly IMediator _mediator;

        public DoctorsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> PostAsync( CreateDoctorCommand doctor)
        {
            int result = await _mediator.Send(doctor);

            return Ok(result);
        }
        [HttpGet]
        
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IEnumerable<Doctor> classes = await _mediator.Send(new GetDoctorQueries());

            return Ok(classes);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromForm] UpdateDoctorCommand @updateDoctor)
        {
            int result = await _mediator.Send(@updateDoctor);
            return Ok(result);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int Id)
        {
            DeleteDoctorCommand doctor = new DeleteDoctorCommand()
            {
                Id = Id
            };

            int result = await _mediator.Send(doctor);

            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(int Id)
        {
            GetByIdQueries doctor = new GetByIdQueries()
            {
                Id = Id,
            };

            Doctor result = await _mediator.Send(doctor);

            return Ok(result);
        }

    }
}
