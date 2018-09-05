﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SJ90.DesktopAPI.Domain;

namespace SJ90.DesktopAPI.Infrastructure.DatabaseMappers
{
    public class SchedulingMap
    {
        public SchedulingMap(EntityTypeBuilder<Scheduling> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Day).IsRequired();
            entityBuilder.Property(t => t.Hour).IsRequired();
            entityBuilder.Property(t => t.Status).IsRequired();

            entityBuilder.HasOne(scheduling => scheduling.Citizen)
                         .WithMany(citizen => citizen.Scheduling)
                         .HasForeignKey(scheduling => scheduling.CitizenId);
        }
    }
}
