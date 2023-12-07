using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.Doctors.Queries.DoctorQueries;
using Ambulance.Application.UseCases.Patients.Queries.PatientQueries;
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
    public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, Patient>

    {
        private readonly IAmbulanceDbContext _context;
        public GetPatientByIdQueryHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<Patient> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            Patient? ambulanceInfo = await _context.patients.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (ambulanceInfo == null)
                throw new Exception();

            return ambulanceInfo;
        }
    }
}
