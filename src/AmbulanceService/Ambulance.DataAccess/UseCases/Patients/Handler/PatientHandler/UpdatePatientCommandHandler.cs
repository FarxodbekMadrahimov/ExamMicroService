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
    public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommand, int>
    {
        private readonly IAmbulanceDbContext _context;

        public UpdatePatientCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            Patient? @ambulanceInfo = await _context.patients.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (@ambulanceInfo == null)
                throw new Exception();

            ambulanceInfo.Id = request.Id;
            ambulanceInfo.Name = request.Name;
            ambulanceInfo.Age = request.Age;
            ambulanceInfo.EmergencyCallId = request.EmergencyCallId;



            _context.patients.Update(@ambulanceInfo);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}