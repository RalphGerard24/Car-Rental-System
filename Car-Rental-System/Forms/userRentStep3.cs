using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class userRentStep3 : Form
    {
        private Customer _currentCustomer;
        private Car _selectedCar;
        private DateTime _rentDateTime;
        private DateTime _returnDateTime;
        private double InitialCost;
        private double TotalCost;

        public userRentStep3(Customer customer, Car car, DateTime rentDate, DateTime returnDate)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _selectedCar = car;
            _rentDateTime = rentDate;     
            _returnDateTime = returnDate;     
            LoadRentDetails();
        }

        private void LoadRentDetails()
        {
            textBox1.Text = _currentCustomer.CustomerId.ToString();
            textBox2.Text = _selectedCar.CarId.ToString();

            // calculation
            int rentDays = (_returnDateTime.Date - _rentDateTime.Date).Days + 1;
            rentDays = Math.Max(rentDays, 1);

            InitialCost = rentDays * _selectedCar.PriceRate;
            double taxRate = 0.12; 
            double taxAmount = InitialCost * taxRate;
            TotalCost = InitialCost + taxAmount;

           
            textBox6.Text = InitialCost .ToString("F2");  // Base price without tax
            textBox7.Text = taxAmount.ToString("F2"); // Tax amount
            textBox4.Text = TotalCost.ToString("F2"); // Initial cost (base + tax)

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
                string transactionCode = TransactionCode();

                var rental = new Rental
                {
                    CarId = _selectedCar.CarId,
                    CustomerId = _currentCustomer.CustomerId,
                    TransactionCode = transactionCode,
                    RentDatee = _rentDateTime,         
                    ReturnDate = _returnDateTime,       
                    InitialCost = InitialCost,
                    TotalCost = TotalCost
                };

                using var available = new CarRentalDbContext();
                var rentService = new RentServices(available);
                rentService.SaveRental(rental);

                // unavailable yung car after marent
                var carToUpdate = available.Cars.Find(rental.CarId);
                if (carToUpdate != null)
                {
                    carToUpdate.IsAvailable = false;
                    available.SaveChanges();
                }

                var confirmationForm = new userRentConfirmed(rental.CustomerId, rental.CarId, rental.TransactionCode);
                confirmationForm.Show();
                this.Hide();
            }
        }
        //auto generate ng transaction code
        private string TransactionCode()
        {
            using var context = new CarRentalDbContext();
            var random = new Random();

            string newCode;
            bool isUnique = false;

            do
            {
                newCode = random.Next(0, 10000).ToString("D4");
                
                bool exists = context.Rentals.Any(r => r.TransactionCode == newCode);

                if (!exists)
                {
                    isUnique = true;
                }

            } while (!isUnique);

            return newCode;
        }


    }
}

