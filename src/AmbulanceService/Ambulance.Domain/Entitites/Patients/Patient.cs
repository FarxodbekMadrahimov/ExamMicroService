
using Ambulance.Domain.Entitites.EmergencyCalls;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace Ambulance.Domain.Entitites.Patients
{

    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        [ForeignKey("EmergencyCall")]
        public int? EmergencyCallId { get; set; }
        [JsonIgnore]
        public EmergencyCalling? EmergencyCall { get; set; }

        
    }

}
