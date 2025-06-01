using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thunders.TechTest.AppHost.Domain.Entities;

namespace Thunders.TechTest.Infrastructure.Mappings;

public class RecordMap : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder.ToTable("Records");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Date)
            .IsRequired();

        builder.Property(r => r.Value)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.Property(r => r.VehicleType)
            .IsRequired();

        builder.HasOne(r => r.Toll)
            .WithMany()
            .HasForeignKey(r => r.TollId);
    }
}
