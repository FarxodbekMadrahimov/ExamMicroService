using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Domain.Dtos
{
    public class UpdateOrdersDto
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string TotalAmount { get; set; }
    }
}
