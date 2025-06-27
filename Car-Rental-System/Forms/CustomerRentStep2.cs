using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

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

            InitializeEventHandlers();
            LoadCustomerData();
            LoadCarData();
            SetDefaultDates();
            UpdateTotalCost();
        }

        private void InitializeEventHandlers()
        {
            this.FormClosing += CustomerRentStep2_FormClosing;
            dateTimePicker1.ValueChanged += DatePickers_ValueChanged;
            dateTimePicker2.ValueChanged += DatePickers_ValueChanged;
            button5.Click += BackButton_Click;
            button6.Click += ProceedButton_Click;
        }

        // Form Event Handlers
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

        // Button Click Events
        private void BackButton_Click(object sender, EventArgs e)
        {
            var rentForm1 = new CustomerRentStep1(_currentCustomer, _admin);
            rentForm1.Show();
            this.Hide();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            _rentDate = dateTimePicker1.Value;
            _returnDate = dateTimePicker2.Value;

            string message =
             "The car must be returned on or before the selected return date and time.\n\n" +
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

        // Value Changed Events
        private void DatePickers_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        // Private Helper Methods
        private void LoadCustomerData()
        {
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
            textBox2.Text = _selectedCar.Model;
            textBox5.Text = _selectedCar.PlateNumber;
            textBox15.Text = _selectedCar.Color;
            textBox6.Text = _selectedCar.Brand;
            textBox16.Text = _selectedCar.PriceRate.ToString("F2");
        }

        private void SetDefaultDates()
        {
            // Set date pickers to include time
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.ShowUpDown = false;
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.ShowUpDown = false;
            dateTimePicker2.Value = DateTime.Now.AddDays(1);

            _rentDate = dateTimePicker1.Value.Date;
            _returnDate = dateTimePicker2.Value.Date;
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

            textBox4.Text = _totalCost.ToString("F2");
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFont(this, FontManager.GlobalFont); // ← use the shared global font
        }

        private void ApplyFont(Control parent, Font font)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Keep size and style, only change font family
                ctrl.Font = new Font(font.FontFamily, ctrl.Font.Size, ctrl.Font.Style);

                if (ctrl.HasChildren)
                    ApplyFont(ctrl, font);
            }
        }
    }
}
