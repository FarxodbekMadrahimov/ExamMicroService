

using Ambulance.Domain.Entitites.EmergencyCalls;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ambulance.Domain.Dtos.PatientDtos
{
    public class PatientDto
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        public int Age { get; set; }

        
        public int EmergencyCallId { get; set; }
        
        
    }
}
