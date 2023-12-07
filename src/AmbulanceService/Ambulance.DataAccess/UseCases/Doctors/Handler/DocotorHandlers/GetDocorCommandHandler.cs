using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.Doctors.Queries.DoctorQueries;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Doctors;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.Doctors.Handler.DocotorHandlers
{
    public class GetDocorCommandHandler : IRequestHandler<GetDoctorQueries, IEnumerable<Doctor>>
    {
        private readonly IAmbulanceDbContext _context;

        public GetDocorCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Doctor>> Handle(GetDoctorQueries request, CancellationToken cancellationToken)
        {
            List<Doctor> result = await _context.doctors.ToListAsync(cancellationToken);
            if (result == null)
                throw new Exception();
            return result;
        }
    }
}
