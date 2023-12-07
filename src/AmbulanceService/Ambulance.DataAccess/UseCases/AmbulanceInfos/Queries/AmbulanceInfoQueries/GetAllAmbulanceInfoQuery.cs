using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries
{
    public class GetAllAmbulanceInfoQuery : IRequest<IEnumerable<AmbulanceInfo>>
    {
    }
}
