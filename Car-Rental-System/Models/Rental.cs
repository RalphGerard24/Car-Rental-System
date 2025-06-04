using System;

namespace Car_Rental_System.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public double? TotalCost { get; set; }

        public Rental() { }

        public Rental(int rentalId, int carId, int customerId, DateTime rentDate, DateTime returnDate, double totalCost)
        {
            RentalId = rentalId;
            CarId = carId;
            CustomerId = customerId;
            RentDate = rentDate;
            ReturnDate = returnDate;
            TotalCost = totalCost;
        }

        public static void RentalTest()
        {
            Console.WriteLine("Rental.cs is used successfully!!!");
        }
    }
}