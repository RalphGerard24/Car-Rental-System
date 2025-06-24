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
        public DateTime? ActualReturnDate { get; set; }
        public double? TotalCost { get; set; }
        public double? InitialCost { get; set; }
        public double LateFee { get; set; }

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

        public string TransactionCode { get; set;  }
        public Rental() { }

        public Rental(int rentalId, int carId, int customerId, DateTime rentDate, DateTime returnDate, double totalCost, string status, string transactionId, double lateFee = 0)
        {
            RentalId = rentalId;
            CarId = carId;
            CustomerId = customerId;
            RentDatee = rentDate;
            ReturnDate = returnDate;
            TotalCost = totalCost;
            TransactionCode = transactionId;
            LateFee = lateFee;
        }
    }
}