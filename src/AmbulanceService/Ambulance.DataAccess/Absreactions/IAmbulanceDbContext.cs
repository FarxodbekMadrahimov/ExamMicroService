using Ambulance.Domain.Entitites.AmbulancesInfo;
using Ambulance.Domain.Entitites.EmergencyCalls;
using Ambulance.Domain.Entitites.Doctors;
using Ambulance.Domain.Entitites.Patients;
using Microsoft.EntityFrameworkCore;

namespace Ambulance.Application.Absreactions
{
    public interface IAmbulanceDbContext
    {
        public DbSet<EmergencyCalling> emergencyCalls { get; set; }
        public DbSet<AmbulanceInfo> amulanceInfo { get; set;}
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}
