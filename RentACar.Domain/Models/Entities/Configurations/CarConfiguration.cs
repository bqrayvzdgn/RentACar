using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RentACar.Domain.Models.Entities.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(x => x.CarID);

        builder.Property(x => x.CarID)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Make)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Model)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Year)
            .IsRequired();

        builder.Property(x => x.PlateNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.DailyRentPrice)
            .IsRequired()
            .HasPrecision(10, 2);

        builder.Property(x => x.IsAvailable)
            .IsRequired();
    }
}
