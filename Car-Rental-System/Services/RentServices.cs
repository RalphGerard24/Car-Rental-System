﻿using Car_Rental_System.Models;
using System.Linq;

namespace Car_Rental_System.Services
{
    
    /// Service class for handling car rental operations including saving rentals and processing returns
   
    public class RentServices
    {
        private readonly CarRentalDbContext _context;

        public RentServices(CarRentalDbContext context)
        {
            _context = context;
        }

      
        /// Saves a new rental record to the database
        /// <param name="rental">The rental object to save</param>
        public void SaveRental(Rental rental)
        {
            _context.Rentals.Add(rental);
            _context.SaveChanges();
        }

        /// Retrieves an ongoing rental for a specific customer (rental without return date)
        /// <param name="customerId">The customer's ID</param>
        /// <returns>The ongoing rental or null if none exists</returns>
        public Rental? GetOngoingRentalByCustomerId(int customerId)
        {
            return _context.Rentals
                .FirstOrDefault(r =>
                    r.CustomerId == customerId &&
                    r.ActualReturnDate == null);
        }

        /// Processes the return of a rental car, updating return date, costs, and car availability
        /// <param name="rental">The rental with updated return information</param>
        public void ReturnCar(Rental rental)
        {
            var rentalToUpdate = _context.Rentals.FirstOrDefault(r => r.RentalId == rental.RentalId);
            if (rentalToUpdate != null)
            {
                rentalToUpdate.ActualReturnDate = rental.ActualReturnDate;
                rentalToUpdate.TotalCost = rental.TotalCost;
                rentalToUpdate.LateFee = rental.LateFee;

                // Mark car as available again
                var car = _context.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                if (car != null)
                {
                    car.IsAvailable = true;
                }

                _context.SaveChanges();
            }
        }
    }
}