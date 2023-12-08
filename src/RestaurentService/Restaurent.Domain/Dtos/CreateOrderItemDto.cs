using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Domain.Dtos
{
    public class CreateOrderItemDto
    {
        public int? MenuItemId { get; set; }
        public int Quantity { get; set; }
        public int? OrderId { get; set; }
    }
}
