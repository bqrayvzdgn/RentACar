namespace RentACar.Domain.Models.Entities;

public class Payment
{
    public int PaymentID { get; set; }

    public int RentalID { get; set; }
    public Rental Rental { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; }
}
