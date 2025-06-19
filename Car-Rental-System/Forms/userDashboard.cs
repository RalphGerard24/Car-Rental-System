using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class userDashboard : Form
    {
        private Customer _currentCustomer;

        public userDashboard(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer;

            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            //textBox1.Text = _currentCustomer.CustomerId.ToString();
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
                        //textBox14.Text = rentedCar.CarId.ToString();       // Car ID
                        textBox13.Text = rentedCar.Model;                  // Model
                        textBox12.Text = rentedCar.Brand;                  // Make
                        textBox11.Text = rentedCar.Color;                  // Color
                        textBox10.Text = recentRental.ReturnDate?.ToString("yyyy-MM-dd") ?? "N/A"; // Due Date
                        textBox9.Text = recentRental.ActualReturnDate == null ? "Ongoing" : "Completed";
                    }
                }
                else
                {
                    //textBox14.Text = textBox13.Text = textBox12.Text =
                    textBox11.Text = textBox10.Text = textBox9.Text = "N/A";
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        { }
        private void label10_Click(object sender, EventArgs e)
        { }
        private void groupBox1_Enter(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            userRentStep1 rentForm = new userRentStep1(_currentCustomer); // Pass the existing customer
            rentForm.Show();
            this.Hide();
        }
    }
}
