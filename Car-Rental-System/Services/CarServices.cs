using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
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

        public static void UpdateCar(Car updatedCar)
        {
            using var db = new CarRentalDbContext();
            var car = db.Cars.FirstOrDefault(c => c.CarId == updatedCar.CarId);
            if (car != null)
            {
                car.Model = updatedCar.Model;
                car.Brand = updatedCar.Brand;
                car.PlateNumber = updatedCar.PlateNumber;
                car.Year = updatedCar.Year;
                car.Color = updatedCar.Color;
                car.PriceRate = updatedCar.PriceRate;
                car.DateRegistered = updatedCar.DateRegistered;
                car.ImagePath = updatedCar.ImagePath;
                car.IsAvailable = updatedCar.IsAvailable;

                db.SaveChanges();
            }
        }

        public static void DeleteCar(int carId)
        {
            using var db = new CarRentalDbContext();
            var car = db.Cars.Find(carId);
            if (car != null)
            {
                db.Cars.Remove(car);
                db.SaveChanges();
            }
        }

        public static Car GetCarById(int carId)
        {
            using var db = new CarRentalDbContext();
            return db.Cars.Find(carId);
        }

        public static List<Car> GetFilteredCars(string brand, string year, bool? isAvailable)
        {
            using var db = new CarRentalDbContext();
            var query = db.Cars.AsQueryable();

            if (!string.IsNullOrEmpty(brand) && brand != "All")
                query = query.Where(c => c.Brand == brand);

            if (!string.IsNullOrEmpty(year) && year != "All")
                query = query.Where(c => c.Year == year);

            if (isAvailable.HasValue)
                query = query.Where(c => c.IsAvailable == isAvailable.Value);

            return query.ToList();
        }

        public static List<string> GetDistinctBrands()
        {
            using var db = new CarRentalDbContext();
            return db.Cars.Select(c => c.Brand).Distinct().ToList();
        }

        public static List<string> GetDistinctYears()
        {
            using var db = new CarRentalDbContext();
            return db.Cars.Select(c => c.Year).Distinct().ToList();
        }
    }
}
