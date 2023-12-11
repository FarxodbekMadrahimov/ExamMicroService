
using Ambulance.Application.Absreactions;
using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.Doctors;
using Ambulance.Domain.Entitites.EmergencyCalls;
using Ambulance.Domain.Entitites.Patients;
using Ambulance.Infrastructure.Persistance.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Ambulance.Infrastructure.Persistance
{
    public class AmbulanceDbContext : DbContext, IAmbulanceDbContext
    {
        public AmbulanceDbContext(DbContextOptions<AmbulanceDbContext> options)
            : base(options)
        {
            var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            try
            {
                if (databaseCreator is null)
                {
                    throw new Exception("Database Not Found!");
                }

                if (!databaseCreator.CanConnect())
                    databaseCreator.CreateAsync();

                if (!databaseCreator.HasTables())
                    databaseCreator.CreateTablesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public DbSet<EmergencyCalling> emergencyCalls { get; set; }
        public DbSet<AmbulanceInfo> amulanceInfo { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmergencyCallConfiguration());
            modelBuilder.ApplyConfiguration(new AmbulanceInfoConfiguration());
        }


    }
}
