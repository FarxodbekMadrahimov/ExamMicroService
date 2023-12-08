using Microsoft.EntityFrameworkCore;
using Restaurent.Domain.Entities.MenuItems;
using Restaurent.Domain.Entities.OrderItems;
using Restaurent.Domain.Entities.Orders;


namespace Restaurent.Application.Absreactions
{
    public interface IRestaurentDbContext
    {
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<MenuItem> menuItems { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
