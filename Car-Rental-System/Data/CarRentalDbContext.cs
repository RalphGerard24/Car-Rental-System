using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Models;
public class CarRentalDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Rental> Rentals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
       optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Car-Rental-DB;Trusted_Connection=True;Encrypt=False");
    }
}
