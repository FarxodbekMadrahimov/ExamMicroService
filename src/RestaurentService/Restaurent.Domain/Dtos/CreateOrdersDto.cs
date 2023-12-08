using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Domain.Dtos
{
    public class CreateOrdersDto
    {
        public DateTime Date { get; set; }
        public string TotalAmount { get; set; }
    }
}
