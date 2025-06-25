using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CustomerRentStep3 : Form
    {
        private Customer _currentCustomer;
        private Car _selectedCar;
        private DateTime _rentDateTime;
        private DateTime _returnDateTime;
        private double _initialCost;
        private double _totalCost;
        private Admin _admin;

        public CustomerRentStep3(Customer customer, Car car, DateTime rentDate, DateTime returnDate, Admin admin)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _selectedCar = car;
            _rentDateTime = rentDate;
            _returnDateTime = returnDate;
            _admin = admin;

            InitializeEventHandlers();
            LoadRentDetails();
        }

        private void InitializeEventHandlers()
        {
            button1.Click += ConfirmRentalButton_Click;
            button3.Click += BackButton_Click;
        }

        // Button Click Events
        private void BackButton_Click(object sender, EventArgs e)
        {
            var rent2 = new CustomerRentStep2(_currentCustomer, _selectedCar, _admin);
            rent2.Show();
            this.Hide();
        }

        private void ConfirmRentalButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to confirm your rental?",
                "Confirm Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                ProcessRental();
            }
        }

        // Private Helper Methods
        private void LoadRentDetails()
        {
            textBox1.Text = _currentCustomer.CustomerId.ToString();
            textBox2.Text = _selectedCar.CarId.ToString();

            // Calculate rental duration with time consideration
            TimeSpan duration = _returnDateTime - _rentDateTime;
            int rentDays = Math.Max(1, (int)Math.Ceiling(duration.TotalDays));

            _initialCost = rentDays * _selectedCar.PriceRate;
            double taxRate = 0.12;
            double taxAmount = _initialCost * taxRate;
            _totalCost = _initialCost + taxAmount;

            textBox6.Text = _initialCost.ToString("F2");
            textBox7.Text = taxAmount.ToString("F2");
            textBox4.Text = _totalCost.ToString("F2");

            // Display date and time
            textBox3.Text = _rentDateTime.ToString("yyyy-MM-dd HH:mm");
            textBox5.Text = _returnDateTime.ToString("yyyy-MM-dd HH:mm");
        }

        private void ProcessRental()
        {
            string transactionCode = GenerateTransactionCode();

            var rental = new Rental
            {
                CarId = _selectedCar.CarId,
                CustomerId = _currentCustomer.CustomerId,
                TransactionCode = transactionCode,
                RentDatee = _rentDateTime,
                ReturnDate = _returnDateTime,
                InitialCost = _initialCost,
                TotalCost = _totalCost,
                LateFee = 0
            };

            using var context = new CarRentalDbContext();
            var rentService = new RentServices(context);
            rentService.SaveRental(rental);

            // Mark car as unavailable
            var carToUpdate = context.Cars.Find(rental.CarId);
            if (carToUpdate != null)
            {
                carToUpdate.IsAvailable = false;
                context.SaveChanges();
            }

            var confirmationForm = new CustomerRentConfirmed(rental.CustomerId, rental.CarId, rental.TransactionCode, _admin);
            confirmationForm.Show();
            this.Hide();
        }

        private string GenerateTransactionCode()
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