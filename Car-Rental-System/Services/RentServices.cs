using Car_Rental_System.Models;
using System.Collections.Generic;
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

    }

}

