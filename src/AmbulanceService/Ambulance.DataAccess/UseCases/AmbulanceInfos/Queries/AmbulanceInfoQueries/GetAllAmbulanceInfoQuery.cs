using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries
{
    public class GetAllAmbulanceInfoQuery : IRequest<IEnumerable<AmbulanceInfo>>
    {
    }
}
