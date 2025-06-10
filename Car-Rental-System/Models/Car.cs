using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Car_Rental_System.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
        public string PlateNumber { get; set; }
        public double PriceRate { get; set; }
        public DateTime DateRegistered { get; set; }
        public bool IsAvailable { get; set; }

        public Car() { }

        public Car(int carId, string brand, string model, string year, string color, string imagePath, string plateNumber, double priceRate, bool isAvailable, DateTime dateRegistered)
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            ImagePath = imagePath;
            PlateNumber = plateNumber;
            PriceRate = priceRate;
            IsAvailable = isAvailable;
            DateRegistered = dateRegistered;
        }


    }
}