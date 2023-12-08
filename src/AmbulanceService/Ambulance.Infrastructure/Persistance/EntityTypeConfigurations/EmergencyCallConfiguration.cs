using Ambulance.Domain.Entitites.EmergencyCalls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Ambulance.Infrastructure.Persistance.EntityTypeConfigurations
{
public class EmergencyCallConfiguration : IEntityTypeConfiguration<EmergencyCalling>
{
    public void Configure(EntityTypeBuilder<EmergencyCalling> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.CallerName).IsRequired();
        builder.Property(e => e.Location).IsRequired();
        builder.Property(e => e.TimeOfCall).IsRequired();
        builder.Property(e => e.AmbulanceDispatched).IsRequired();

       
    }
}
}
