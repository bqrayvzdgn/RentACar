namespace RentACar.Domain.Models.Entities;

public class Car
{
    public int CarID { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string PlateNumber { get; set; }

    public decimal DailyRentPrice { get; set; }

    public bool IsAvailable { get; set; }
}
