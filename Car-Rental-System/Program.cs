using Car_Rental_System;
using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Reset 
            using (var context = new CarRentalDbContext())
            {
                // Wipe 
                context.Rentals.RemoveRange(context.Rentals);
                context.Customers.RemoveRange(context.Customers);
                context.Cars.RemoveRange(context.Cars);
                context.SaveChanges();

                // Insert dummy
                context.Cars.AddRange(
                    new Car(1, "Toyota", "Vios", 1200, true),
                    new Car(2, "Honda", "Civic", 1500, true)
                );

                
                context.Customers.AddRange(
                    new Customer(1, "Ralph Gerard", "09278545387"),
                    new Customer(2, "Rosse Ferrer", "09121212121")
                );

                context.Rentals.Add(
                    new Rental(1, 1, 1, DateTime.Today, DateTime.Today.AddDays(3), 3600)
                );

                context.SaveChanges();
            }

            Application.Run(new Form1());
        }
    }
}
