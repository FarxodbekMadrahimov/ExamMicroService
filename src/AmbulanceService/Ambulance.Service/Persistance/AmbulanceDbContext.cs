using Ambulance.Application;

using Microsoft.EntityFrameworkCore;

namespace Ambulance.Infrastructure.Persistance
{
    public class AmbulanceDbContext : DbContext , IAmbulanceDbContext
    {
    }
}
