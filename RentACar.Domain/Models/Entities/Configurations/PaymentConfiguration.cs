using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RentACar.Domain.Models.Entities.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(x => x.PaymentID);

        builder.Property(x => x.PaymentID)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.PaymentDate)
            .HasColumnType("timestamp")
            .IsRequired();

        builder.Property(x => x.Amount)
            .IsRequired()
            .HasPrecision(10, 2);

        builder.Property(x => x.PaymentMethod)
            .IsRequired()
            .HasMaxLength(50);
    }
}
