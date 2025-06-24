using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CustomerReturn : Form
    {
        private int _customerId;
        private int _carId;
        private Admin _admin;

        public CustomerReturn(int customerId, int carId, Admin admin)
        {
            InitializeComponent();
            _customerId = customerId;
            _carId = carId;
            _admin = admin;

            LoadReturnInfo();
            buttonConfirmReturn.Click += buttonConfirmReturn_Click;
        }

        private void LoadReturnInfo()
        {
            CustomerIDTextBox.Text = _customerId.ToString();
            CarIDTextBox.Text = _carId.ToString();

            using (var db = new CarRentalDbContext())
            {
                var rental = db.Rentals
                    .FirstOrDefault(r => r.CustomerId == _customerId &&
                                         r.CarId == _carId &&
                                         r.ActualReturnDate == null);

                if (rental != null)
                {
                    var customer = db.Customers.Find(_customerId);
                    var car = db.Cars.Find(_carId);

                    textBox2.Text = customer?.FirstName + " " + customer?.LastName;
                    textBox6.Text = car?.PlateNumber;

                    textBox5.Text = rental.RentDatee.ToString("yyyy-MM-dd");
                    textBox3.Text = DateTime.Today.ToString("yyyy-MM-dd");

                    textBox10.Text = rental.InitialCost?.ToString("F2");
                    textBox9.Text = ((rental.InitialCost ?? 0) * 0.12).ToString("F2");
                    textBox7.Text = rental.TotalCost?.ToString("F2");

                    int lateDays = (DateTime.Today - (rental.ReturnDate ?? DateTime.Today)).Days;
                    double penalty = lateDays > 0 ? lateDays * 500 : 0;
                    textBox8.Text = penalty.ToString("F2");
                }
                else
                {
                    MessageBox.Show("No active rental found.");
                }
            }
        }

        private void buttonConfirmReturn_Click(object sender, EventArgs e)
        {
            using (var db = new CarRentalDbContext())
            {
                var rental = db.Rentals
                    .FirstOrDefault(r => r.CustomerId == _customerId &&
                                         r.CarId == _carId &&
                                         r.ActualReturnDate == null);

                if (rental != null)
                {
                    rental.ActualReturnDate = DateTime.Today;

                    int lateDays = (DateTime.Today - (rental.ReturnDate ?? DateTime.Today)).Days;
                    rental.LateFee = lateDays > 0 ? lateDays * 500 : 0;

                    var car = db.Cars.Find(_carId);
                    if (car != null)
                    {
                        car.IsAvailable = true;
                    }

                    db.SaveChanges();
                    MessageBox.Show("Car return confirmed and processed successfully.");

                    var dashboard = new AdminDashboard(_admin);
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No active rental found to return.");
                }
            }
        }
    }
}
