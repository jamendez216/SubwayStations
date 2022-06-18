using Microsoft.EntityFrameworkCore;
using SubwayStations.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SubwayStations.Entities.Database
{
    public class SubwayStationsDbContext : DbContext
    {
        public DbSet<SubwayStation> SubwayStations { get; set; }
        public DbSet<UserSubwayStation> UserSubwayStations { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
