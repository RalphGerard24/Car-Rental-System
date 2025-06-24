using Car_Rental_System.Models;
using System.Linq;

namespace Car_Rental_System.Services
{
    public class RentServices
    {
        private readonly CarRentalDbContext _rent;

        public RentServices(CarRentalDbContext rent_)
        {
            _rent = rent_;
        }

        public void SaveRental(Rental rental)
        {
            _rent.Rentals.Add(rental);
            _rent.SaveChanges();
        }

        public Rental? GetOngoingRentalByCustomerId(int customerId)
        {
            return _rent.Rentals
                .FirstOrDefault(r =>
                    r.CustomerId == customerId &&
                    r.ActualReturnDate == null); // not returned yet
        }

        public void ReturnCar(Rental rental)
        {
            var rentalToUpdate = _rent.Rentals.FirstOrDefault(r => r.RentalId == rental.RentalId);
            if (rentalToUpdate != null)
            {
                rentalToUpdate.ActualReturnDate = rental.ActualReturnDate;
                rentalToUpdate.TotalCost = rental.TotalCost;
                rentalToUpdate.LateFee = rental.LateFee;

                var car = _rent.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                if (car != null)
                {
                    car.IsAvailable = true;
                }

                _rent.SaveChanges();
            }
        }
    }
}
