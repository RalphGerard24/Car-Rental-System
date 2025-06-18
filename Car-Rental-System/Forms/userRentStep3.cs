using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class userRentStep3 : Form
    {
        private Customer _currentCustomer;
        private Car _selectedCar;
        private DateTime _rentDateTime;
        private DateTime _returnDateTime;
        private double _totalCost;

        public userRentStep3(Customer customer, Car car, DateTime rentDate, DateTime returnDate)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _selectedCar = car;
            _rentDateTime = DateTime.Now;     
            _returnDateTime = returnDate;     
            LoadRentDetails();
        }

        private void LoadRentDetails()
        {
            textBox1.Text = _currentCustomer.CustomerId.ToString();
            textBox2.Text = _selectedCar.CarId.ToString();
            //calculation
            int rentDays = (_returnDateTime.Date - _rentDateTime.Date).Days + 1;
            rentDays = Math.Max(rentDays, 1);

            _totalCost = rentDays * _selectedCar.PriceRate;
            textBox4.Text = _totalCost.ToString("F2");

   
            textBox3.Text = _rentDateTime.ToString("yyyy-MM-dd");
            textBox5.Text = _returnDateTime.ToString("yyyy-MM-dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rent2 = new userRentStep2(_currentCustomer, _selectedCar);
            rent2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to confirm your rental?",
                "Confirm Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string transactionId = TransactionId();

                var rental = new Rental
                {
                    CarId = _selectedCar.CarId,
                    CustomerId = _currentCustomer.CustomerId,
                    TransactionId = transactionId,
                    RentDatee = _rentDateTime,         
                    ReturnDate = _returnDateTime,       
                    TotalCost = _totalCost
                };

                using var context = new CarRentalDbContext();
                var rentService = new RentServices(context);
                rentService.SaveRental(rental);

                // unavailable yung car after marent
                var carToUpdate = context.Cars.Find(rental.CarId);
                if (carToUpdate != null)
                {
                    carToUpdate.IsAvailable = false;
                    context.SaveChanges();
                }

                var confirmationForm = new userRentConfirmed(rental.CustomerId, rental.CarId, rental.TransactionId);
                confirmationForm.Show();
                this.Hide();
            }
        }
        //auto generate ng transaction id
        private string TransactionId()
        {
            using var context = new CarRentalDbContext();

            var lastTransaction = context.Rentals
                .OrderByDescending(r => r.TransactionId)
                .Select(r => r.TransactionId)
                .FirstOrDefault();

            int lastNumber = 0;
            char prefix = 'a';

            if (!string.IsNullOrEmpty(lastTransaction) && lastTransaction.Length > 1)
            {
                var numberPart = lastTransaction.Substring(1);
                int.TryParse(numberPart, out lastNumber);
            }

            return $"{prefix}{++lastNumber}";
        }
    }
}
