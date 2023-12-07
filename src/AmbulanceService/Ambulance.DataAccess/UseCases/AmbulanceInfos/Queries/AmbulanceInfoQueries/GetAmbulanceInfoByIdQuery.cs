
using Ambulance.Domain.Entitites.AmbulancesInfo;
using MediatR;

namespace Ambulance.Application.UseCases.AmbulanceInfos.Queries.AmbulanceInfoQueries
{
    public class GetAmbulanceInfoByIdQuery : IRequest<AmbulanceInfo>
    {
        public int Id { get; set; }
    }
}
