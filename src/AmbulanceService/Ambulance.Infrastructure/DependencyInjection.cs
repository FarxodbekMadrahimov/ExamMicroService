using Ambulance.Application.Absreactions;
using Ambulance.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ambulance.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructures(this IServiceCollection services, IConfiguration configuration)
    {
        var localConnaction = configuration.GetConnectionString("DockerConnection");
        var dockerConnection = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<IAmbulanceDbContext, AmbulanceDbContext>(options =>
        {
            options.UseSqlServer(dockerConnection);
        });

        return services;
    }
}
