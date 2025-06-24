using Car_Rental_System.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using System;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly Admin _currentAdmin;

        public AdminDashboard(Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            LoadDashboardData();

            // Navigation buttons
            button1.Click += (s, e) => { };

            button2.Click += (s, e) =>
            {
                var ManageCarsForm = new ManageCars(_currentAdmin);
                ManageCarsForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                ManageCarsForm.Show();
            };

            button4.Click += (s, e) =>
            {
                var ManageCustomerForm = new ManageCustomer(_currentAdmin);
                ManageCustomerForm.FormClosed += (_, __) => this.Close();
                this.Hide();
                ManageCustomerForm.Show();
            };

            button3.Click += button3_Click;



        }

        //private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;

        private void LoadDashboardData()
        {
            using var context = new CarRentalDbContext();

            var salesPerDay = context.Rentals
                .Where(r => r.RentDatee >= DateTime.Now.AddDays(-7))
                .GroupBy(r => r.RentDatee.Date)
                .Select(g => new { Date = g.Key, Count = g.Count() })
                .ToList();

            // Create the line series
            var lineSeries = new LineSeries<int>
            {
                Values = salesPerDay.Select(x => x.Count).ToArray()
            };

            // Assign X-axis labels
            chartSales.XAxes = new[]
            {
                new Axis
                {
                    Labels = salesPerDay.Select(x => x.Date.ToShortDateString()).ToArray(),
                    LabelsRotation = 15,
                    Name = "Date"
                }
            };

            chartSales.YAxes = new[]
            {
                new Axis
                {
                    Name = "Rentals"
                }
            };

            // Assign the series to the chart
            chartSales.Series = new ISeries[] { lineSeries };




            // 1. Total Customers
            int customerCount = context.Customers.Count();
            labelCustomerCount.Text = customerCount.ToString();

            // 2. Total Cars
            int carCount = context.Cars.Count();
            labelCarCount.Text = carCount.ToString();

            // 3. Cars on Rent
            int rentedCount = context.Rentals.Count(r => r.ReturnDate == null);
            labelCarsOnRent.Text = rentedCount.ToString();

            // 4. Available Cars
            int availableCount = context.Cars.Count(c => c.IsAvailable);
            labelCarsAvailable.Text = availableCount.ToString();

            // 5. Total Revenue (optional: use ActualReturnDate to exclude ongoing)
            double totalRevenue = context.Rentals
                .Where(r => r.TotalCost.HasValue)
                .Sum(r => r.TotalCost.Value);
            labelRevenue.Text = totalRevenue.ToString("C"); // "₱0.00"
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RentalRecords rentalRecordsForm = new RentalRecords(_currentAdmin);
            rentalRecordsForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            rentalRecordsForm.Show();
        }
    }
}