using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Services
{
  
    /// Service class for managing customer data operations
    /// Provides CRUD operations for Customer entities with proper error handling
    
    public static class CustomerService
    {
        #region Create Operations
      
        /// Adds a new customer to the database
        /// <param name="customer">The customer object to add</param>
        public static void AddCustomer(Customer customer)
        {
            using var db = new CarRentalDbContext();
            db.Customers.Add(customer);
            db.SaveChanges();
        }
        #endregion

        #region Read Operations

        /// Retrieves a customer by their unique ID
        /// <param name="customerId">The unique identifier of the customer</param>
        /// <returns>Customer object if found, null otherwise</returns>
        public static Customer GetCustomerById(int customerId)
        {
            using var db = new CarRentalDbContext();
            return db.Customers.Find(customerId);
        }

        /// Retrieves all customers from the database
        /// <returns>List of all customers, empty list if none found</returns>
        public static List<Customer> GetAllCustomers()
        {
            using var db = new CarRentalDbContext();
            return db.Customers.ToList();
        }

        /// Searches customers by name (first or last name contains search term)
        /// <param name="searchTerm">The term to search for in customer names</param>
        /// <returns>List of customers matching the search criteria</returns>
        public static List<Customer> SearchCustomersByName(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllCustomers();

            try
            {
                using var db = new CarRentalDbContext();
                var term = searchTerm.Trim().ToLower();

                return db.Customers
                    .Where(c => c.FirstName.ToLower().Contains(term) ||
                               c.LastName.ToLower().Contains(term))
                    .OrderBy(c => c.LastName)
                    .ThenBy(c => c.FirstName)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to search customers: {ex.Message}", ex);
            }
        }

        /// Checks if a customer exists with the given ID
        /// <param name="customerId">The customer ID to check</param>
        /// <returns>True if customer exists, false otherwise</returns>
        public static bool CustomerExists(int customerId)
        {
            if (customerId <= 0)
                return false;

            try
            {
                using var db = new CarRentalDbContext();
                return db.Customers.Any(c => c.CustomerId == customerId);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to check customer existence: {ex.Message}", ex);
            }
        }
        #endregion

    
        /// Retrieves customers filtered by exact age and/or city
        /// <param name="age">Exact age to filter, or null for any age</param>
        /// <param name="city">City to filter, or null/"All" for any city</param>
        /// <returns>List of customers matching the filters</returns>
        public static List<Customer> GetFilteredCustomers(int? age, string city)
        {
            using var db = new CarRentalDbContext();
            var query = db.Customers.AsQueryable();

            if (age.HasValue)
                query = query.Where(c => c.Age == age.Value.ToString()); // Note: Age is stored as string in your model

            if (!string.IsNullOrWhiteSpace(city) && city != "All")
                query = query.Where(c => c.City == city);

            return query.OrderBy(c => c.CustomerId).ToList();
        }


        #region Update Operations
  
        /// Updates an existing customer's information
        /// <param name="updatedCustomer">Customer object with updated information</param>
        /// <exception cref="ArgumentNullException">Thrown when updatedCustomer is null</exception>
        /// <exception cref="InvalidOperationException">Thrown when customer not found or update fails</exception>
        /// 
        public static void UpdateCustomer(Customer updatedCustomer)
        {
            if (updatedCustomer == null)
                throw new ArgumentNullException(nameof(updatedCustomer), "Updated customer cannot be null.");

            if (updatedCustomer.CustomerId <= 0)
                throw new ArgumentException("Customer ID must be greater than zero.", nameof(updatedCustomer));

            try
            {
                using var db = new CarRentalDbContext();
                var existingCustomer = db.Customers.Find(updatedCustomer.CustomerId);

                if (existingCustomer == null)
                    throw new InvalidOperationException($"Customer with ID {updatedCustomer.CustomerId} not found.");

                // Update customer properties
                existingCustomer.FirstName = updatedCustomer.FirstName?.Trim();
                existingCustomer.LastName = updatedCustomer.LastName?.Trim();
                existingCustomer.MiddleInnitial = updatedCustomer.MiddleInnitial?.Trim();
                existingCustomer.Age = updatedCustomer.Age?.Trim();
                existingCustomer.ContactNumber = updatedCustomer.ContactNumber?.Trim();
                existingCustomer.LicenseNumber = updatedCustomer.LicenseNumber?.Trim();
                existingCustomer.Email = updatedCustomer.Email?.Trim();
                existingCustomer.City = updatedCustomer.City?.Trim();
                existingCustomer.Barangay = updatedCustomer.Barangay?.Trim();
                existingCustomer.ZipCode = updatedCustomer.ZipCode?.Trim();

                db.SaveChanges();
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to update customer: {ex.Message}", ex);
            }
        }
        #endregion

        #region Delete Operations
  
        /// Deletes a customer from the database by ID
        /// <param name="customerId">The unique identifier of the customer to delete</param>
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

        /// Safely deletes a customer, checking for related records first
        /// <param name="customerId">The customer ID to delete</param>
        /// <returns>True if deleted successfully, false if customer has active rentals</returns>
        public static bool SafeDeleteCustomer(int customerId)
        {
            if (customerId <= 0)
                throw new ArgumentException("Customer ID must be greater than zero.", nameof(customerId));

            try
            {
                using var db = new CarRentalDbContext();
                var customer = db.Customers.Find(customerId);

                if (customer == null)
                    return true; // Already doesn't exist

                // Check for active rentals or rental history
                var hasActiveRentals = db.Rentals?.Any(r => r.CustomerId == customerId) ?? false;

                if (hasActiveRentals)
                    return false; // Cannot delete customer with rental history

                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to safely delete customer: {ex.Message}", ex);
            }
        }
        #endregion

        #region Utility Methods

        /// Gets the total count of customers in the database
        /// <returns>Total number of customers</returns>
        public static int GetCustomerCount()
        {
            try
            {
                using var db = new CarRentalDbContext();
                return db.Customers.Count();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to get customer count: {ex.Message}", ex);
            }
        }
        /// Validates customer data before database operations
        /// <param name="customer">Customer to validate</param>
        /// <returns>True if valid, false otherwise</returns>
        public static bool ValidateCustomerData(Customer customer)
        {
            if (customer == null)
                return false;

            // Check required fields
            return !string.IsNullOrWhiteSpace(customer.FirstName) &&
                   !string.IsNullOrWhiteSpace(customer.LastName) &&
                   !string.IsNullOrWhiteSpace(customer.Email) &&
                   !string.IsNullOrWhiteSpace(customer.ContactNumber) &&
                   !string.IsNullOrWhiteSpace(customer.LicenseNumber);
        }
        #endregion
    }
}