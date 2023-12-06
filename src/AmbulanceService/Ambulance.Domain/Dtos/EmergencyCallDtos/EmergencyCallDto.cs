using Ambulance.Domain.Entitites.AmbulancesInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ambulance.Domain.Dtos.EmergencyCallDtos
{
    public class EmergencyCallDto
    {
        public int Id { get; set; }      
        public string CallerName { get; set; }       
        public string Location { get; set; }       
        public DateTime TimeOfCall { get; set; }
        public bool AmbulanceDispatched { get; set; }      
        public int? AmbulanceId { get; set; }
        
    }
}
