using Restaurent.Domain.Entities.OrderItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Domain.Entities.MenuItems
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        
        public ICollection<OrderItem> OrderItems { get; set; }
    }

}
