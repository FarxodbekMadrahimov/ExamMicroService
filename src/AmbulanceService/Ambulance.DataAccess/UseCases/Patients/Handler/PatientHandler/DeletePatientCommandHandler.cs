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
    public class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommand, int>
    {
        private readonly IAmbulanceDbContext _context;
        public DeletePatientCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            Patient? doctor = await _context.patients.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (doctor == null)
                throw new Exception();

            _context.patients.Remove(doctor);
            int result = await _context.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
