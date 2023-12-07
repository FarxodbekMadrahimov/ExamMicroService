using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
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
    public class GetDoctorByIdQueryHandler : IRequestHandler<GetByIdQueries,Doctor>
    {
        private readonly IAmbulanceDbContext _context;
        public GetDoctorByIdQueryHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<Doctor> Handle(GetByIdQueries request, CancellationToken cancellationToken)
        {
            Doctor? ambulanceInfo = await _context.doctors.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (ambulanceInfo == null)
                throw new Exception();

            return ambulanceInfo;
        }
    }
}
