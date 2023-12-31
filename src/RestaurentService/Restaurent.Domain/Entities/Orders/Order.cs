﻿using Restaurent.Domain.Entities.OrderItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Domain.Entities.Orders
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
