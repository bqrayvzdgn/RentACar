using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RentACar.Domain.Models.Entities.Configurations;

public class RentalConfiguration : IEntityTypeConfiguration<Rental>
{
    public void Configure(EntityTypeBuilder<Rental> builder)
    {
        builder.HasKey(x => x.RentalID);

        builder.Property(x => x.RentalID)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.RentStartDate)
            .HasColumnType("timestamp")
            .IsRequired();

        builder.Property(x => x.RentEndDate)
            .HasColumnType("timestamp")
            .IsRequired();

        builder.Property(x => x.TotalPrice)
            .IsRequired()
            .HasPrecision(10, 2);
    }
}
