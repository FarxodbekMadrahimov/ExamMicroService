using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Application.UseCases.EmergencyCalls.Command.EmergencyCommand
{
    public class CreateEmergencyCallCommnad : IRequest
    {
        public int Id { get; set; }
        public string CallerName { get; set; }
        public string Location { get; set; }
        public DateTime TimeOfCall { get; set; }
        public bool AmbulanceIsDispatched { get; set; }
        public int? AmbulanceId { get; set; }
    }
}
