using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentACar.Domain.Models.Entities;
using RentACar.Domain.Models.Entities.Configurations;

namespace RentACar.Infrastructure.Context;

public class ApplicationDbContext(IConfiguration _configuration, DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    private readonly IConfiguration Configuration = _configuration;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        modelBuilder.ApplyConfiguration(new RentalConfiguration());
    }

    public DbSet<Car> Car { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Rental> Rental { get; set; }
}
