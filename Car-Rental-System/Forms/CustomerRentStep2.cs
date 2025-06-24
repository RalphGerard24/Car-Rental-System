using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Car_Rental_System
{
    public partial class CustomerRentStep2 : Form
    {
        private Customer _currentCustomer;
        private Car _selectedCar;
        private DateTime _rentDate;
        private DateTime _returnDate;
        private double _totalCost;
        private Admin _admin;
        public CustomerRentStep2(Customer customer, Car selectedCar, Admin admin)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _selectedCar = selectedCar;
            _admin = admin;
            this.FormClosing += CustomerRentStep2_FormClosing;
            

            LoadCustomerData();
            LoadCarData();


            _rentDate = dateTimePicker1.Value.Date;
            _returnDate = dateTimePicker2.Value.Date;


            dateTimePicker1.ValueChanged += DatePickers_ValueChanged;
            dateTimePicker2.ValueChanged += DatePickers_ValueChanged;

            UpdateTotalCost();
        }

        private void LoadCustomerData()
        {
            //textBox12.Text = _currentCustomer.CustomerId.ToString();
            textBox11.Text = $"{_currentCustomer.FirstName} {_currentCustomer.LastName}";
            textBox10.Text = _currentCustomer.Age;
            textBox9.Text = _currentCustomer.ContactNumber;
            textBox3.Text = _currentCustomer.City;
            textBox13.Text = _currentCustomer.Barangay;
            textBox14.Text = _currentCustomer.ZipCode;
            textBox8.Text = _currentCustomer.Email;
            textBox7.Text = _currentCustomer.LicenseNumber;
        }

        private void LoadCarData()
        {
            //textBox1.Text = _selectedCar.CarId.ToString();
            textBox2.Text = _selectedCar.Model;
            textBox5.Text = _selectedCar.PlateNumber;
            textBox15.Text = _selectedCar.Color;
            textBox6.Text = _selectedCar.Brand;
            textBox16.Text = _selectedCar.PriceRate.ToString("F2");
        }

        private void UpdateTotalCost()
        {
            _rentDate = dateTimePicker1.Value.Date;
            _returnDate = dateTimePicker2.Value.Date;

            if (_rentDate < DateTime.Today || _returnDate < _rentDate)
            {
                textBox4.Text = "Invalid Dates";
                return;
            }

            int rentDays = (_returnDate - _rentDate).Days + 1;
            _totalCost = rentDays * _selectedCar.PriceRate;

            //textBox3.Text = _rentDate.ToString("yyyy-MM-dd");
           // textBox5.Text = _returnDate.ToString("yyyy-MM-dd");
            textBox4.Text = _totalCost.ToString("F2");
        }

        private void DatePickers_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var rentForm1 = new CustomerRentStep1(_currentCustomer, _admin);
            rentForm1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _rentDate = dateTimePicker1.Value.Date;
            _returnDate = dateTimePicker2.Value.Date;

            string message =
             "The car must be returned on or before the selected return date ends.\n\n" +
             "Late returns beyond the selected return date may incur an additional charge " +
             "equivalent to one full day's rental fee.\n\n" +
             "Additional charges for damages, cleaning, or late returns may be assessed upon inspection. " +
             "These are handled separately by our staff.\n\n" +
             "Do you want to proceed?";

            var result = MessageBox.Show(message, "Important Rental Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var rentForm3 = new CustomerRentStep3(_currentCustomer, _selectedCar, _rentDate, _returnDate, _admin);
                rentForm3.Show();
                this.Hide();
            }
        }

        

        private void CustomerRentStep2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                var result = MessageBox.Show(
                    "This will cancel the Rental Process. Do you want to return to Profile?",
                    "Confirm Action",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }

                var profileForm = new CustomerProfile(_currentCustomer, _admin);
                profileForm.Show();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void textBox12_TextChanged(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

}
