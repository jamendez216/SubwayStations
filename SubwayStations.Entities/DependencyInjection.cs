using Microsoft.Extensions.DependencyInjection;
using SubwayStations.Entities.Database;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace SubwayStations.Entities
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SubwayStationsDbContext>(options =>
             options.UseSqlServer(
                 configuration.GetConnectionString("DbContext"),
                 b => b.MigrationsAssembly(typeof(SubwayStationsDbContext).Assembly.FullName)));

            return services;
        }
    }
}
