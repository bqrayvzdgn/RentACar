namespace RentACar.Domain.Models.Entities;

public class Rental
{
    public int RentalID { get; set; }

    public int CustomerID { get; set; }
    public Customer Customer { get; set; }

    public int CarID { get; set; }
    public Car Car { get; set; }

    public DateTime RentStartDate { get; set; }

    public DateTime RentEndDate { get; set; }

    public decimal TotalPrice { get; set; }
}
