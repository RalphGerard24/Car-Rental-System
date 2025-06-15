using Car_Rental_System.Models;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Services
{
    public static class CustomerService
    {
        // Add a new customer
        public static void AddCustomer(Customer customer)
        {
            using var db = new CarRentalDbContext();
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        // Delete an existing customer by ID
        public static void DeleteCustomer(int customerId)
        {
            using var db = new CarRentalDbContext();
            var customer = db.Customers.Find(customerId);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        // Retrieve a customer by ID
        public static Customer GetCustomerById(int customerId)
        {
            using var db = new CarRentalDbContext();
            return db.Customers.Find(customerId);
        }

        // Retrieve all customers
        public static List<Customer> GetAllCustomers()
        {
            using var db = new CarRentalDbContext();
            return db.Customers.ToList();
        }

        /* Optionally, update customer (if edit feature is added later)
        public static void UpdateCustomer(Customer updatedCustomer)
        {
            using var db = new CarRentalDbContext();
            var existingCustomer = db.Customers.FirstOrDefault(c => c.CustomerId == updatedCustomer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.FirstName = updatedCustomer.FirstName;
                existingCustomer.LastName = updatedCustomer.LastName;
                existingCustomer.MiddleInnitial = updatedCustomer.MiddleInnitial;
                existingCustomer.Age = updatedCustomer.Age;
                existingCustomer.ContactNumber = updatedCustomer.ContactNumber;
                existingCustomer.LicenseNumber = updatedCustomer.LicenseNumber;
                existingCustomer.Email = updatedCustomer.Email;
                existingCustomer.City = updatedCustomer.City;
                existingCustomer.Barangay = updatedCustomer.Barangay;
                existingCustomer.ZipCode = updatedCustomer.ZipCode;

                db.SaveChanges();
            }
        } */
    }
}
