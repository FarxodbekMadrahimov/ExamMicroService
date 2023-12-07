using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambulance.Domain.Dtos;
using Ambulance.Domain.Dtos.AmbulanceInfoDtos;
using MediatR;
namespace Ambulance.Application.UseCases.AmbulanceInfos.Commands.AmbulanceInfoCommand
{
    public class CreateAmbulanceInfoCommand : AmbulanceInfoDto , IRequest<int>
    {
    }
}
