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

namespace Car_Rental_System.Forms
{
    public partial class RentalRecords : Form
    {
        private CarRentalDbContext _context;

        private readonly Admin _currentAdmin;
        public RentalRecords(Admin admin)
        {
            InitializeComponent();
            _context = new CarRentalDbContext();
            LoadRentalRecords();
            _currentAdmin = admin;

            button1.Click += (s, e) =>
            {
                var dashboardForm = new AdminDashboard(_currentAdmin);
                dashboardForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                dashboardForm.Show();
            };

            // Navigation to Manage Cars
            button2.Click += (s, e) =>
            {
                var manageCarsForm = new ManageCars(_currentAdmin);
                manageCarsForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                manageCarsForm.Show();
            };

            // Navigation to Manage Customers
            button4.Click += (s, e) =>
            {
                var manageCustomerForm = new ManageCustomer(_currentAdmin);
                manageCustomerForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                manageCustomerForm.Show();
            };

            // Log Out (optional if you have button7)
            button7.Click += (s, e) =>
            {
                this.Close(); // or show LoginForm if applicable
            };
        }

        private void LoadRentalRecords()
        {
            var rentalData = _context.Rentals
                .Join(_context.Customers,
                      rental => rental.CustomerId,
                      customer => customer.CustomerId,
                      (rental, customer) => new { rental, customer })
                .Join(_context.Cars,
                      combined => combined.rental.CarId,
                      car => car.CarId,
                      (combined, car) => new
                      {
                          RentalId = combined.rental.RentalId,
                          CustomerName = combined.customer.FirstName + " " + combined.customer.LastName,
                          Car = car.Brand + " " + car.Model,
                          PlateNumber = car.PlateNumber,
                          RentDate = combined.rental.RentDatee,
                          ReturnDate = combined.rental.ReturnDate,
                          ActualReturnDate = combined.rental.ActualReturnDate,
                          InitialCost = combined.rental.InitialCost,
                          LateFee = combined.rental.LateFee,
                          TotalCost = combined.rental.TotalCost,
                          Status = combined.rental.Status,
                          TransactionCode = combined.rental.TransactionCode
                      })
                .ToList();

            dataGridView1.DataSource = rentalData;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}