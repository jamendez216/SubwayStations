using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SubwayStations.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubwayStations.Entities.Database.Configurations
{
    public class UserSubwayStationConfiguration : IEntityTypeConfiguration<UserSubwayStation>
    {
        public void Configure(EntityTypeBuilder<UserSubwayStation> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
