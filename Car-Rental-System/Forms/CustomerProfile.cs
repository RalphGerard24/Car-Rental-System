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

        public CustomerProfile(Customer customer, Admin admin)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _admin = admin;

            this.FormClosing += CustomerProfile_FormClosing;

            LoadCustomerData();

            button4.Click += button4_Click;     // Return button
            button6.Click += button6_Click;     // View status
            button5.Click += button5_Click;     // Edit/Save button
        }

        private void LoadCustomerData()
        {
            textBox3.Text = $"{_currentCustomer.FirstName} {_currentCustomer.LastName}";
            textBox5.Text = _currentCustomer.Age;
            textBox4.Text = _currentCustomer.ContactNumber;
            textBox6.Text = _currentCustomer.City;
            textBox8.Text = _currentCustomer.Barangay;
            textBox15.Text = _currentCustomer.ZipCode;
            textBox2.Text = _currentCustomer.Email;
            textBox7.Text = _currentCustomer.LicenseNumber;

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
                        textBox10.Text = recentRental.ReturnDate?.ToString("yyyy-MM-dd") ?? "N/A";
                        textBox9.Text = recentRental.ActualReturnDate == null ? "Ongoing" : "Completed";
                    }
                }
                else
                {
                    textBox11.Text = textBox10.Text = textBox9.Text = "N/A";
                }
            }

            SetFieldsReadOnly(true);
            button5.Text = "Edit";
            _isEditMode = false;
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            textBox3.ReadOnly = readOnly;
            textBox5.ReadOnly = readOnly;
            textBox4.ReadOnly = readOnly;
            textBox6.ReadOnly = readOnly;
            textBox8.ReadOnly = readOnly;
            textBox15.ReadOnly = readOnly;
            textBox2.ReadOnly = readOnly;
            textBox7.ReadOnly = readOnly;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                // 🔓 Enter Edit Mode
                SetFieldsReadOnly(false);
                button5.Text = "Save";
                _isEditMode = true;

                // ✅ Use BeginInvoke to delay MessageBox
                this.BeginInvoke((Action)(() =>
                {
                    MessageBox.Show("Edit mode enabled. Make changes and click Save.");
                }));
            }
            else
            {
                // 💾 Save Mode
                using (var db = new CarRentalDbContext())
                {
                    var customerInDb = db.Customers.FirstOrDefault(c => c.CustomerId == _currentCustomer.CustomerId);
                    if (customerInDb != null)
                    {
                        var fullName = textBox3.Text.Trim().Split(' ');
                        customerInDb.FirstName = fullName[0];
                        customerInDb.LastName = fullName.Length > 1 ? fullName[1] : "";

                        customerInDb.Age = textBox5.Text;
                        customerInDb.ContactNumber = textBox4.Text;
                        customerInDb.City = textBox6.Text;
                        customerInDb.Barangay = textBox8.Text;
                        customerInDb.ZipCode = textBox15.Text;
                        customerInDb.Email = textBox2.Text;
                        customerInDb.LicenseNumber = textBox7.Text;

                        db.SaveChanges();
                        _currentCustomer = customerInDb;

                        MessageBox.Show("Customer info saved successfully!");
                    }
                }

                // 🔒 Lock fields again
                SetFieldsReadOnly(true);
                button5.Text = "Edit";
                _isEditMode = false;
            }
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

            this.Hide();
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

        private void CustomerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                var manageCustomerForm = new ManageCustomer(_admin);
                manageCustomerForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerRentStep1 rentForm = new CustomerRentStep1(_currentCustomer, _admin);
            rentForm.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
