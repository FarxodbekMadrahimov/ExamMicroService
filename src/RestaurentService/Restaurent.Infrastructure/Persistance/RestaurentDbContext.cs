﻿using Microsoft.EntityFrameworkCore;
using Restaurent.Application.Absreactions;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.OrderItems;
using Restaurent.Domain.Entities.Orders;
using Restaurent.Infrastructures.EnityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.Infrastructures.Persistance
{
    public class RestaurentDbContext : DbContext, IRestaurentDbContext
    {

        public RestaurentDbContext(DbContextOptions<RestaurentDbContext> options)
            : base(options)
        {

        }
        public DbSet<OrderItem> orderItems { get ; set ; }
        public DbSet<Order> orders { get ; set ; }
        public DbSet<MenuItem> menuItems { get ; set ; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new MenuItemConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());

            

            base.OnModelCreating(modelBuilder);
        }
    }
}
