using Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand;
using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
using Ambulance.Application.UseCases.Doctors.Command.DoctorCommands;
using Ambulance.Application.UseCases.Doctors.Handler.DocotorHandlers;
using Ambulance.Application.UseCases.Doctors.Queries.DoctorQueries;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Doctors;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ambulance.API.Controllers
{
    [Route("api/[controller]")]
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


    }
}
