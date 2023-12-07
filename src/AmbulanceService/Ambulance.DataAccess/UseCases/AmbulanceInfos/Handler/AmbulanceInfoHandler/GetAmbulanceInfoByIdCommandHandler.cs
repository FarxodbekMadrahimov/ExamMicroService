using Ambulance.Application.Absreactions;
using Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Handler.AmbulanceInfoHandler
{
    public class GetAmbulanceInfoByIdCommandHandler : IRequestHandler<GetAmbulanceInfoByIdQuery,AmbulanceInfo>
    {
        private readonly IAmbulanceDbContext _context;
        public GetAmbulanceInfoByIdCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<AmbulanceInfo> Handle(GetAmbulanceInfoByIdQuery request, CancellationToken cancellationToken)
        {
            AmbulanceInfo? ambulanceInfo = await _context.amulanceInfo.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (ambulanceInfo == null)
                throw new Exception();

            return ambulanceInfo;
        }
    }
}
