using BeautyClinic.Core.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeautyClinic.Infrastructure.Context.Mapping.Patient;

public class MeasurementsMapping : IEntityTypeConfiguration<Measurements>
{
    public void Configure(EntityTypeBuilder<Measurements> builder)
    {
        builder.ToTable("Measurements");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
        .ValueGeneratedOnAdd()
        .UseMySqlIdentityColumn();

        builder.Property(x => x.Weight)
        .IsRequired();

        builder.Property(x => x.Height)
        .IsRequired();

        builder.Property(x => x.Hip)
        .IsRequired();

        builder.Property(x => x.Bust)
        .IsRequired();

        builder.Property(x => x.LeftArm)
        .IsRequired();

        builder.Property(x => x.RightArm)
        .IsRequired();

        builder.Property(x => x.UpperAbdomen)
        .IsRequired();

        builder.Property(x => x.LeftThigh)
        .IsRequired();

        builder.Property(x => x.RightThigh)
        .IsRequired();

        builder.Property(x => x.LeftCalf)
        .IsRequired();

        builder.Property(x => x.RightCalf)
        .IsRequired();

        builder.Property(x => x.MeasurementDate)
        .IsRequired();

        builder.HasOne(x => x.Client)
        .WithMany(x => x.Measurements)
        .HasForeignKey(x => x.ClientId);
    }
}
