﻿using Car_Rental_System.Models;
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

            // Total Customers
            int customerCount = context.Customers.Count();
            labelCustomerCount.Text = customerCount.ToString();

            // Total Cars
            int carCount = context.Cars.Count();
            labelCarCount.Text = carCount.ToString();

            // Cars on Rent
            int rentedCount = context.Rentals.Count(r => r.ActualReturnDate == null);
            labelCarsOnRent.Text = rentedCount.ToString();

            // Available Cars
            int availableCount = context.Cars.Count(c => c.IsAvailable);
            labelCarsAvailable.Text = availableCount.ToString();

            // Total Revenue (optional: use ActualReturnDate to exclude ongoing)
            using (var db = new CarRentalDbContext())
            {
                var totalRevenueBeforeVAT = db.Rentals
                    .Where(r => r.TotalCost != null && r.ActualReturnDate != null)
                    .Sum(r => r.TotalCost.Value / 1.12);

                labelRevenue.Text = totalRevenueBeforeVAT.ToString("C");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rentalRecordsForm = new RentalRecords(_currentAdmin);
            rentalRecordsForm.FormClosed += (_, __) => this.Close();
            rentalRecordsForm.ShowDialog();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFont(this, FontManager.GlobalFont); // use the shared global font
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
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();


            LoginPage loginForm = new LoginPage();
            loginForm.Show();

            this.Close();
        }
    }
}
