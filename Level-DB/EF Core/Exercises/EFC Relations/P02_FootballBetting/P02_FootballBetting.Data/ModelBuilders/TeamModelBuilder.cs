﻿namespace P02_FootballBetting.Data.ModelBuilders
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using P02_FootballBetting.Data.Models;

    public class TeamModelBuilder
        : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                        .HasOne(t => t.PrimaryKitColor)
                        .WithMany(c => c.PrimaryKitTeams)
                        .HasForeignKey(t => t.PrimaryKitColorId)
                        .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(t => t.SecondaryKitColor)
                .WithMany(c => c.SecondaryKitTeams)
                .HasForeignKey(t => t.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
