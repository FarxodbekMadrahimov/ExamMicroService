using Ambulance.Domain.Entitites.EmergencyCalls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ambulance.Domain.Dtos.AmbulanceInfoDtos
{
    public class AmbulanceInfoDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public bool Available { get; set; }
    }
}
