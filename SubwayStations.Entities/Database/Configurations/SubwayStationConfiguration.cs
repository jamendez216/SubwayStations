using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SubwayStations.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubwayStations.Entities.Database.Configurations
{
    public class SubwayStationConfiguration : IEntityTypeConfiguration<SubwayStation>
    {
        public void Configure(EntityTypeBuilder<SubwayStation> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedNever();

            builder.HasIndex(e => new { e.Latitude, e.Longitude})
                .IsUnique();
            
        }
    }
}
