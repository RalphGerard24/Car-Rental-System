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
        public double PriceRate { get; set; }
        public bool IsAvailable { get; set; }

        public Car(int carId, string brand, string model, double priceRate, bool isAvailable)
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            PriceRate = priceRate;
            IsAvailable = isAvailable;
        }

        public static void CarTest()
        {
            Console.WriteLine("The Car.cs is used successfulyy!!!");
        }


    }
}