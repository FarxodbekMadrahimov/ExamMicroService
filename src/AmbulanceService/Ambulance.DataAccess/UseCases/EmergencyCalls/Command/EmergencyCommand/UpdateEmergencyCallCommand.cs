using Ambulance.Application.UseCases.EmergencyCalls.Command;
using Ambulance.Domain.Entitites.EmergencyCalls;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambulance.Domain.Dtos;
using Ambulance.Domain.Dtos.EmergencyCallDtos;

namespace Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand
{
    public class UpdateEmergencyCallCommand : EmergencyCallDto, IRequest<int>
    {

    }
}
