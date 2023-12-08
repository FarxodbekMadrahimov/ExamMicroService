
using Ambulance.Application.Absreactions;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Doctors;
using Ambulance.Domain.Entitites.Patients;
using Microsoft.EntityFrameworkCore;
using Ambulance.Domain.Entitites.EmergencyCalls;
using Ambulance.Infrastructure.Persistance.EntityTypeConfigurations;

namespace Ambulance.Infrastructure.Persistance
{
    public class AmbulanceDbContext : DbContext, IAmbulanceDbContext
    {
        public AmbulanceDbContext(DbContextOptions<AmbulanceDbContext> options) 
            :base(options) 
        {


        }
        public DbSet<EmergencyCalling> emergencyCalls { get ; set ; }        
        public DbSet<AmbulanceInfo> amulanceInfo { get ; set ; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set ; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmergencyCallConfiguration());
            modelBuilder.ApplyConfiguration(new AmbulanceInfoConfiguration());
        }


    }
}
