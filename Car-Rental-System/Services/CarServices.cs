using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Services
{
    public static class CarService
    {

        /// Adds a new car to the database
        /// <param name="car">Car object to be added</param>
        /// <exception cref="ArgumentNullException">Thrown when car is null</exception>
        /// 
        public static void AddCar(Car car)
        {
            if (car == null)
                throw new ArgumentNullException(nameof(car), "Car cannot be null");

            using var db = new CarRentalDbContext();
            db.Cars.Add(car);
            db.SaveChanges();
        }

        /// Updates an existing car in the database
        /// <param name="updatedCar">Car object with updated information</param>
        /// <exception cref="ArgumentNullException">Thrown when updatedCar is null</exception>
        /// <returns>True if car was updated, false if car not found</returns>
       
        public static bool UpdateCar(Car updatedCar)
        {
            if (updatedCar == null)
                throw new ArgumentNullException(nameof(updatedCar), "Updated car cannot be null");

            using var db = new CarRentalDbContext();
            var existingCar = db.Cars.FirstOrDefault(c => c.CarId == updatedCar.CarId);

            if (existingCar == null)
                return false;

            UpdateCarProperties(existingCar, updatedCar);
            db.SaveChanges();
            return true;
        }

        /// Deletes a car from the database
        /// <param name="carId">ID of the car to delete</param>
        /// <returns>True if car was deleted, false if car not found</returns>
        public static bool DeleteCar(int carId)
        {
            using var db = new CarRentalDbContext();
            var car = db.Cars.Find(carId);

            if (car == null)
                return false;

            db.Cars.Remove(car);
            db.SaveChanges();
            return true;
        }

       
        /// Retrieves a car by its ID
        /// <param name="carId">ID of the car to retrieve</param>
        /// <returns>Car object if found, null otherwise</returns>
        public static Car GetCarById(int carId)
        {
            using var db = new CarRentalDbContext();
            return db.Cars.Find(carId);
        }

    
        /// Gets filtered list of cars based on brand, year, and availability
        /// <param name="brand">Brand filter (null or "All" for no filter)</param>
        /// <param name="year">Year filter (null or "All" for no filter)</param>
        /// <param name="isAvailable">Availability filter (null for no filter)</param>
        /// <returns>List of cars matching the filters</returns>
        public static List<Car> GetFilteredCars(string brand, string year, bool? isAvailable)
        {
            using var db = new CarRentalDbContext();
            var query = db.Cars.AsQueryable();

            query = ApplyBrandFilter(query, brand);
            query = ApplyYearFilter(query, year);
            query = ApplyAvailabilityFilter(query, isAvailable);

            return query.OrderBy(c => c.CarId).ToList();

        }

        /// Gets all distinct car brands from the database
        /// <returns>List of unique car brands</returns>
        public static List<string> GetDistinctBrands()
        {
            using var db = new CarRentalDbContext();
            return db.Cars
                .Where(c => !string.IsNullOrEmpty(c.Brand))
                .Select(c => c.Brand)
                .Distinct()
                .OrderBy(b => b)
                .ToList();
        }

        /// Gets all distinct car years from the database
        /// <returns>List of unique car years</returns>
        public static List<string> GetDistinctYears()
        {
            using var db = new CarRentalDbContext();
            return db.Cars
                .Where(c => !string.IsNullOrEmpty(c.Year))
                .Select(c => c.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();
        }

        /// Gets all available cars
        /// <returns>List of available cars</returns>
        public static List<Car> GetAvailableCars()
        {
            return GetFilteredCars(null, null, true);
        }

        /// Checks if a car with the given plate number already exists
        /// <param name="plateNumber">Plate number to check</param>
        /// <param name="excludeCarId">Car ID to exclude from check (for updates)</param>
        /// <returns>True if plate number exists, false otherwise</returns>
        public static bool IsPlateNumberExists(string plateNumber, int? excludeCarId = null)
        {
            if (string.IsNullOrWhiteSpace(plateNumber))
                return false;

            using var db = new CarRentalDbContext();
            var query = db.Cars.Where(c => c.PlateNumber == plateNumber);

            if (excludeCarId.HasValue)
                query = query.Where(c => c.CarId != excludeCarId.Value);

            return query.Any();
        }

        private static void UpdateCarProperties(Car existingCar, Car updatedCar)
        {
            existingCar.Model = updatedCar.Model;
            existingCar.Brand = updatedCar.Brand;
            existingCar.PlateNumber = updatedCar.PlateNumber;
            existingCar.Year = updatedCar.Year;
            existingCar.Color = updatedCar.Color;
            existingCar.PriceRate = updatedCar.PriceRate;
            existingCar.DateRegistered = updatedCar.DateRegistered;
            existingCar.ImagePath = updatedCar.ImagePath;
            existingCar.IsAvailable = updatedCar.IsAvailable;
        }

        private static IQueryable<Car> ApplyBrandFilter(IQueryable<Car> query, string brand)
        {
            if (!string.IsNullOrEmpty(brand) && brand != "All")
                return query.Where(c => c.Brand == brand);
            return query;
        }

        private static IQueryable<Car> ApplyYearFilter(IQueryable<Car> query, string year)
        {
            if (!string.IsNullOrEmpty(year) && year != "All")
                return query.Where(c => c.Year == year);
            return query;
        }

        private static IQueryable<Car> ApplyAvailabilityFilter(IQueryable<Car> query, bool? isAvailable)
        {
            if (isAvailable.HasValue)
                return query.Where(c => c.IsAvailable == isAvailable.Value);
            return query;
        }
    }
}