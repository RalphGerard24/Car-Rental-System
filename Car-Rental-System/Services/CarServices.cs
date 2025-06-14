using Car_Rental_System.Models;
using System;
using System.Linq;

namespace Car_Rental_System.Services
{
    public static class CarService
    {
        public static void AddCar(Car car)
        {
            using var db = new CarRentalDbContext(); 
            db.Cars.Add(car);
            db.SaveChanges();
        }
    }

    public static class CustomerService
    {
        public static void AddCustomer(Customer customer)
        {
            using var db = new CarRentalDbContext();
            db.Customers.Add(customer);
            db.SaveChanges();
        }
    }
}
