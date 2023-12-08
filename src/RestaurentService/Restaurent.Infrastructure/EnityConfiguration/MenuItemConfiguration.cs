using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurent.Domain.Entities.MenuItems;
namespace Restaurent.Infrastructures.EnityConfiguration
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            
        }
    }
}
