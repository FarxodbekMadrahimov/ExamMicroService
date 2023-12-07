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
    public class GetPatientCommandHandler : IRequestHandler<GetAllPatientsQuery, IEnumerable<Patient>>
    {
        private readonly IAmbulanceDbContext _context;

        public GetPatientCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Patient>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            List<Patient> result = await _context.patients.ToListAsync(cancellationToken);
            if (result == null)
                throw new Exception();
            return result;
        }
    }
}
