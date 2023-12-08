using Ambulance.Domain.Entitites.AmbulancesInfo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance.Infrastructure.Persistance.EntityTypeConfigurations
{
    public class AmbulanceInfoConfiguration : IEntityTypeConfiguration<AmbulanceInfo>
    {
        public void Configure(EntityTypeBuilder<AmbulanceInfo> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Model).IsRequired();
            builder.Property(a => a.Available).IsRequired();

            
        }
    }
}
