using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CustomerRentConfirmed : Form
    {
        private int _customerId;
        private int _carId;
        private string _transactionId;
        private Admin _admin;

        public CustomerRentConfirmed(int customerId, int carId, string transactionId, Admin admin)
        {
            InitializeComponent();
            _customerId = customerId;
            _carId = carId;
            _transactionId = transactionId;
            _admin = admin;

            InitializeEventHandlers();
            LoadRentData();
        }

        private void InitializeEventHandlers()
        {
            button1.Click += FinishButton_Click;
        }

        // Button Click Events
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You successfully rented the car.", "Rental Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var dashboard = new AdminDashboard(_admin);
            dashboard.Show();
            this.Close();
        }

        // Private Helper Methods
        private void LoadRentData()
        {
            using var db = new CarRentalDbContext();

            // Fetch customer and car data from the database
            var customer = db.Customers.FirstOrDefault(c => c.CustomerId == _customerId);
            var car = db.Cars.FirstOrDefault(c => c.CarId == _carId);

            string middleInitial = string.IsNullOrWhiteSpace(customer.MiddleInnitial) ? "" : $"{customer.MiddleInnitial}.";
            textBox1.Text = $"{customer.LastName}, {customer.FirstName} {middleInitial}";
            textBox2.Text = $"{car.Brand} {car.Model}";
            textBox4.Text = _transactionId;
        }

        private void ApplyFont(Control parent, Font font)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Only change the font family, keep the control's original size and style
                ctrl.Font = new Font(font.FontFamily, ctrl.Font.Size, ctrl.Font.Style);

                if (ctrl.HasChildren)
                    ApplyFont(ctrl, font);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFont(this, FontManager.GlobalFont);
        }

    }
}