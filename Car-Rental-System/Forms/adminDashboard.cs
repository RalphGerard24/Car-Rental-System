using Car_Rental_System.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Painting;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly Admin _currentAdmin;
        private CartesianChart salesChart;


        public AdminDashboard(Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;
            // Create and add the chart to the form
            salesChart = new CartesianChart
            {
                Dock = DockStyle.Top,
                Height = 300,
                Margin = new Padding(10)
            };

            panel6.Controls.Add(salesChart);
            panel6.Controls.SetChildIndex(salesChart, 0);


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

        private void LoadDashboardData()
        {
            using var context = new CarRentalDbContext();

            var salesPerDay = context.Rentals
           .Where(r => r.RentDatee >= DateTime.Now.AddDays(-30)) // last 30 days
           .AsEnumerable()
           .GroupBy(r => r.RentDatee.Date) // group by actual day
           .Select(g => new { Day = g.Key.ToShortDateString(), Count = g.Count() })
           .OrderBy(x => DateTime.Parse(x.Day))
           .ToList();

            // Create Line Series
            var lineSeries = new LineSeries<int>
            {
                Values = salesPerDay.Select(x => x.Count).ToArray(),
                Name = "Rentals per Day",
                Stroke = new SolidColorPaint(SKColors.Blue, 2),
                Fill = null
            };

            // Assign series to chart
            salesChart.Series = new ISeries[] { lineSeries };

            // X-axis labels
            salesChart.XAxes = new[]
            {
               new Axis
                  {
                Labels = salesPerDay.Select(x => x.Day).ToArray(),
                LabelsRotation = 15,
                Name = "Date"
                }
             };

            // Y-axis
            salesChart.YAxes = new[]
            {
            new Axis
                 {
                   Name = "Total Rentals"
                  }
            };

            // 1. Total Customers
            int customerCount = context.Customers.Count();
            labelCustomerCount.Text = customerCount.ToString();

            // 2. Total Cars
            int carCount = context.Cars.Count();
            labelCarCount.Text = carCount.ToString();

            // 3. Cars on Rent
            int rentedCount = context.Rentals.Count(r => r.ActualReturnDate == null);
            labelCarsOnRent.Text = rentedCount.ToString();

            // 4. Available Cars
            int availableCount = context.Cars.Count(c => c.IsAvailable);
            labelCarsAvailable.Text = availableCount.ToString();

            // 5. Total Revenue (optional: use ActualReturnDate to exclude ongoing)
            using (var db = new CarRentalDbContext())
            {
                var totalRevenueBeforeVAT = db.Rentals
                    .Where(r => r.TotalCost != null && r.ActualReturnDate != null)
                    .Sum(r => r.TotalCost.Value / 1.12);

                labelRevenue.Text = totalRevenueBeforeVAT.ToString("C");
            }
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
