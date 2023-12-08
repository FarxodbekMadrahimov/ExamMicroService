using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Domain.Entitites
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [ForeignKey(nameof(MenuItem))]
        public int MenuItemId { get; set; }
        

        public int Quantity { get; set; }
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        
        public MenuItem MenuItem { get; set; }
        public Order Order { get; set; }
    }

}
