using Ambulance.Domain.Entitites.EmergencyCalls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ambulance.Domain.Entitites.AmbulancesInfo
{
    public class AmbulanceInfo
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        public bool Available { get; set; }
        [JsonIgnore]
        public List<EmergencyCalling>? EmergencyCalls { get; set; }

    }
}
