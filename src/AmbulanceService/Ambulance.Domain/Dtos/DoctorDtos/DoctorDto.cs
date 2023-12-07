using Ambulance.Domain.Entitites.EmergencyCalls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ambulance.Domain.Dtos.DoctorDtos
{
    public class DoctorDto
    {
        public string Name { get; set; }

        public string Specialization { get; set; }

        public int? EmergencyCallId { get; set; }
    }
}
