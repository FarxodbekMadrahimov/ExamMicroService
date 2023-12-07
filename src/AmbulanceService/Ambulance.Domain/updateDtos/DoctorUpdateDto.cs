using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Domain.updateDtos
{
    public class DoctorUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Specialization { get; set; }

        public int? EmergencyCallId { get; set; }
    }
}
