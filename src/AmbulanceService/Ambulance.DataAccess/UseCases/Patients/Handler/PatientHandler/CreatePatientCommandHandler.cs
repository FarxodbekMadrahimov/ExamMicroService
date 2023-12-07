using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.Doctors.Command.DoctorCommands;
using Ambulance.Application.UseCases.Patients.Command.PatientCommands;
using Ambulance.Domain.Entitites.Doctors;
using Ambulance.Domain.Entitites.Patients;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Patients.Handler.PatientHandler
{
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IAmbulanceDbContext _context;

        public CreatePatientCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            Patient? ambulanceInfo = await _context.patients.FirstOrDefaultAsync(cancellationToken);



            Patient doctor = new Patient()
            {
                Name = request.Name,
                Age = request.Age,
                EmergencyCallId = request.EmergencyCallId,

            };
            await _context.patients.AddAsync(doctor, cancellationToken);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
