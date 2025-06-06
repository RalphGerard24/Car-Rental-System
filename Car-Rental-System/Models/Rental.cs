using System;

namespace Car_Rental_System.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDatee { get; set; }
        public DateTime? ReturnDate { get; set; }
        public double? TotalCost { get; set; }

        public string Status {
            get
            {
                if (ReturnDate == null)
                {
                    return "Rented";
                }
                else
                {
                    return "Returned";
                }
            }
        }

        public string TransactionId { get; set;  }


        public Rental(int rentalId, int carId, int customerId, DateTime rentDate, DateTime returnDate, double totalCost, string status, string transactionId)
        {
            RentalId = rentalId;
            CarId = carId;
            CustomerId = customerId;
            RentDatee = rentDate;
            ReturnDate = returnDate;
            TotalCost = totalCost;
            Status = status;
            TransactionId = transactionId;
        }

        public static void RentalTest()
        {
            Console.WriteLine("Rental.cs is used successfully!!!");
        }
    }
}