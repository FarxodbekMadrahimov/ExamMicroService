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
    public class GetAmbulanceInfoCommandHandler: IRequestHandler<GetAllAmbulanceInfoQuery, IEnumerable<AmbulanceInfo>>
    {
        private readonly IAmbulanceDbContext _context;

        public GetAmbulanceInfoCommandHandler(IAmbulanceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AmbulanceInfo>> Handle(GetAllAmbulanceInfoQuery request, CancellationToken cancellationToken)
        {
           List<AmbulanceInfo> result = await _context.amulanceInfo.ToListAsync(cancellationToken);
            if (result == null)
                throw new Exception();
            return result;            
        }
    }
}
