
using Ambulance.Domain.Entitites.AmbulancesInfo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ambulance.Domain.Entitites.EmergencyCalls
{
    public class EmergencyCalling
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string CallerName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime TimeOfCall { get; set; }

        public bool AmbulanceDispatched { get; set; }

         
        [ForeignKey("Ambulance")]
        public int? AmbulanceId { get; set; }
        
        [JsonIgnore]
        public AmbulanceInfo? Ambulance { get; set; }
    }
}
