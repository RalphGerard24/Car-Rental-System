using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CustomerReturn : Form
    {
        private int _customerId;
        private int _carId;
        private Admin _admin;
        private Customer _currentCustomer;

        // Constructor - Initializes the return form with customer, car, and admin data
        public CustomerReturn(int customerId, int carId, Admin admin)
        {
            InitializeComponent();

            _customerId = customerId;
            _carId = carId;
            _admin = admin;

            // Load customer data from database
            using (var db = new CarRentalDbContext())
            {
                _currentCustomer = db.Customers.Find(_customerId);
            }

            LoadReturnInfo();
            InitializeEventHandlers();
        }

        // Button Click Events
        private void buttonConfirmReturn_Click(object sender, EventArgs e)
        {
            using (var db = new CarRentalDbContext())
            {
                var rental = db.Rentals
                    .FirstOrDefault(r => r.CustomerId == _customerId &&
                                         r.CarId == _carId &&
                                         r.ActualReturnDate == null);

                var car = db.Cars.Find(_carId);

                if (rental != null && car != null)
                {
                    rental.ActualReturnDate = DateTime.Today;

                    // Calculate late fees if return is overdue
                    if (rental.ReturnDate.HasValue)
                    {
                        int lateDays = (DateTime.Today - rental.ReturnDate.Value).Days;
                        rental.LateFee = lateDays > 0 ? lateDays * car.PriceRate : 0;
                    }
                    else
                    {
                        rental.LateFee = 0;
                    }

                    car.IsAvailable = true;
                    db.SaveChanges();

                    MessageBox.Show("Car return confirmed and processed successfully.");

                    var dashboard = new AdminDashboard(_admin);
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No active rental or car record found.");
                }
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            var profileForm = new CustomerProfile(_currentCustomer, _admin);
            profileForm.Show();
            this.Hide();
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            var rentForm = new CustomerRentStep1(_currentCustomer, _admin);
            rentForm.Show();
            this.Hide();
        }

        private void buttonManageCustomer_Click(object sender, EventArgs e)
        {
            var manageCustomerForm = new ManageCustomer(_admin);
            manageCustomerForm.Show();
            this.Hide();
        }

        // Private Helper Methods
        private void InitializeEventHandlers()
        {
            buttonConfirmReturn.Click += buttonConfirmReturn_Click;
            button1.Click += buttonProfile_Click;
            button2.Click += buttonRent_Click;
            button3.Click += buttonManageCustomer_Click;
        }

        private void LoadReturnInfo()
        {
            CustomerIDTextBox.Text = _customerId.ToString();

            using (var db = new CarRentalDbContext())
            {
                var rental = db.Rentals
                    .FirstOrDefault(r => r.CustomerId == _customerId &&
                                         r.CarId == _carId &&
                                         r.ActualReturnDate == null);

                var customer = db.Customers.Find(_customerId);
                var car = db.Cars.Find(_carId);

                if (rental != null && car != null)
                {
                    // Populate car and customer information
                    CarNameTextBox.Text = $"{car.Brand} {car.Model}";
                    textBox2.Text = $"{customer?.FirstName} {customer?.LastName}";
                    textBox6.Text = car.PlateNumber;
                    textBox5.Text = rental.RentDatee.ToString("yyyy-MM-dd");
                    textBox3.Text = rental.ReturnDate?.ToString("yyyy-MM-dd") ?? "N/A";

                    // Populate cost information
                    textBox10.Text = rental.InitialCost?.ToString("F2");
                    textBox9.Text = ((rental.InitialCost ?? 0) * 0.12).ToString("F2"); // 12% tax
                    textBox7.Text = rental.TotalCost?.ToString("F2");

                    // Calculate and display penalty for late return
                    double penalty = 0;
                    if (rental.ReturnDate.HasValue)
                    {
                        int lateDays = (DateTime.Today - rental.ReturnDate.Value).Days;
                        penalty = lateDays > 0 ? lateDays * car.PriceRate : 0;
                    }
                    textBox8.Text = penalty.ToString("F2");
                }
                else
                {
                    MessageBox.Show("No active rental found.");
                }
            }
        }

    }
}