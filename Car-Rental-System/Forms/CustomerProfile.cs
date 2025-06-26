using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CustomerProfile : Form
    {
        private Admin _admin;
        private Customer _currentCustomer;
        private bool _isEditMode = false;

        // Constructor - Initializes the CustomerProfile form with customer and admin data
        public CustomerProfile(Customer customer, Admin admin)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _admin = admin;

            // Attach event handlers
            this.FormClosing += CustomerProfile_FormClosing;
            button3.Click += button3_Click;     // Back to Admin
            button4.Click += button4_Click;     // Return button
            //button5.Click += button5_Click;     // Edit/Save button
            button6.Click += button6_Click;     // View status

            LoadCustomerData();
        }

        // Form Event Handlers
        private void CustomerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                var manageCustomerForm = new ManageCustomer(_admin);
                manageCustomerForm.Show();
            }
        }

        // Button Click Events
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerRentStep1 rentForm = new CustomerRentStep1(_currentCustomer, _admin);
            rentForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var manageCustomerForm = new ManageCustomer(_admin);
            this.Hide();
            manageCustomerForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var db = new CarRentalDbContext())
            {
                var ongoingRental = db.Rentals
                    .FirstOrDefault(r => r.CustomerId == _currentCustomer.CustomerId && r.ActualReturnDate == null);

                if (ongoingRental != null)
                {
                    var returnForm = new CustomerReturn(_currentCustomer.CustomerId, ongoingRental.CarId, _admin);
                    returnForm.Show();
                }
                else
                {
                    MessageBox.Show("No active rental found to return.", "Return Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            using (var db = new CarRentalDbContext())
            {
                var recentRental = db.Rentals
                    .Where(r => r.CustomerId == _currentCustomer.CustomerId)
                    .OrderByDescending(r => r.RentDatee)
                    .FirstOrDefault();

                if (recentRental != null)
                {
                    var rentedCar = db.Cars.FirstOrDefault(c => c.CarId == recentRental.CarId);
                    if (rentedCar != null)
                    {
                        var carDetailsForm = new CarDetails(rentedCar.CarId, true);
                        carDetailsForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Car details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No rental history found for this customer.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Private Helper Methods
        private void LoadCustomerData()
        {
            // Load customer personal information
            textBox3.Text = $"{_currentCustomer.FirstName} {_currentCustomer.LastName}";
            textBox5.Text = _currentCustomer.Age;
            textBox4.Text = _currentCustomer.ContactNumber;
            textBox6.Text = _currentCustomer.City;
            textBox8.Text = _currentCustomer.Barangay;
            textBox15.Text = _currentCustomer.ZipCode;
            textBox2.Text = _currentCustomer.Email;
            textBox7.Text = _currentCustomer.LicenseNumber;

            // Load recent rental information
            using (var db = new CarRentalDbContext())
            {
                var recentRental = db.Rentals
                    .Where(r => r.CustomerId == _currentCustomer.CustomerId)
                    .OrderByDescending(r => r.RentDatee)
                    .FirstOrDefault();

                if (recentRental != null)
                {
                    var rentedCar = db.Cars.FirstOrDefault(c => c.CarId == recentRental.CarId);
                    if (rentedCar != null)
                    {
                        textBox13.Text = rentedCar.Model;
                        textBox12.Text = rentedCar.Brand;
                        textBox11.Text = rentedCar.Color;
                        textBox10.Text = recentRental.ReturnDate?.ToString("yyyy-MM-dd") ?? "";
                        textBox9.Text = recentRental.ActualReturnDate == null ? "Ongoing" : "Completed";
                    }
                }
                else
                {
                    textBox13.Text = textBox12.Text = textBox11.Text = textBox10.Text = textBox9.Text = "";
                }
            }

            // SetFieldsReadOnly(true);
            // button5.Text = "Edit";
            //_isEditMode = false;
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            textBox3.ReadOnly = readOnly;
            textBox5.ReadOnly = readOnly;
            textBox4.ReadOnly = readOnly;
            textBox6.ReadOnly = readOnly;
            textBox8.ReadOnly = readOnly;
            textBox15.ReadOnly = readOnly;
            textBox2.Text = _currentCustomer.Email;
            textBox7.ReadOnly = readOnly;
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}