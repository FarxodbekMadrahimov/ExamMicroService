
using Ambulance.Domain.Dtos.AmbulanceInfoDtos;
using Ambulance.Domain.updateDtos;
using MediatR;


namespace Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand
{
    public class UpdateAmbulanceInfoCommand : AmbulanceInfoDto , IRequest<int>
    {
        public int Id { get; set; }
    }
}
