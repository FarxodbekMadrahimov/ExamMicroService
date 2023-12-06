using Ambulance.Domain.Entitites.EmergencyCalls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Ambulance.Domain.Entitites.Doctors
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Specialization { get; set; }

        
        [ForeignKey("EmergencyCall")]
        public int? EmergencyCallId { get; set; }
        [JsonIgnore]
        public EmergencyCalling? EmergencyCall { get; set; }       
    }
}
