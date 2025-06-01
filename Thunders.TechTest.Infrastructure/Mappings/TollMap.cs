using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thunders.TechTest.AppHost.Domain.Entities;

namespace Thunders.TechTest.Infrastructure.Mappings;

internal class TollMap : IEntityTypeConfiguration<Toll>
{
    public void Configure(EntityTypeBuilder<Toll> builder)
    {
        builder.ToTable("Tolls");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.City)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(t => t.State)
            .IsRequired()
            .HasMaxLength(2);
    }
}
