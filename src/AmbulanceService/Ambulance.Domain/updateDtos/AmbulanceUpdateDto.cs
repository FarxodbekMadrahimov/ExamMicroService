using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Domain.updateDtos
{
    public class AmbulanceUpdateDto
    {
        public int Id;
        public string Model { get; set; }

        public bool Available { get; set; }
    }
}
