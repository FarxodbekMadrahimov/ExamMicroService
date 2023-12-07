using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand
{
    public class DeleteAmbulanceInfoHandler : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
