using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class CarDetails : Form
    {
        private int? _rentalId;
        private int? _carId;

        public CarDetails(int rentalId)
        {
            InitializeComponent();
            _rentalId = rentalId;
            this.FormClosing += CarDetails_FormClosing; 
        }
        public CarDetails(int carId, bool directCarView)
        {
            InitializeComponent();
            _carId = carId;
            this.FormClosing += CarDetails_FormClosing;
        }
        private void CarDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            var manageCarsForm = new ManageCars();
            //manageCarsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ManageCars = new ManageCars(); 
            ManageCars.Show();
            this.Close();
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {
            using var db = new CarRentalDbContext();
            Rental rental = null;

            if (_rentalId.HasValue)
            {
                rental = db.Rentals.FirstOrDefault(r => r.RentalId == _rentalId.Value);
            }
            else if (_carId.HasValue)
            {
                rental = db.Rentals.FirstOrDefault(r => r.CarId == _carId.Value && r.ReturnDate == null);
            }

            Car car = null;
            Customer customer = null;

            if (rental != null)
            {
                car = db.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                customer = db.Customers.FirstOrDefault(c => c.CustomerId == rental.CustomerId);
            }
            else if (_carId.HasValue)
            {
                car = db.Cars.FirstOrDefault(c => c.CarId == _carId.Value);
            }

            if (car == null)
            {
                MessageBox.Show("Car not found.");
                return;
            }

            textBox1.Text = car.CarId.ToString();
            textBox2.Text = car.Model;
            textBox4.Text = car.Brand;
            textBox5.Text = car.Color;
            textBox6.Text = car.PlateNumber;
            textBox3.Text = car.DateRegistered.ToString("yyyy-MM-dd");
            if (!string.IsNullOrEmpty(car.ImagePath) && File.Exists(car.ImagePath))
                pictureBox1.Image = Image.FromFile(car.ImagePath);

            if (rental != null && customer != null)
            {
                // --- Customer Info ---
                textBox12.Text = customer.CustomerId.ToString();
                textBox11.Text = $"{customer.FirstName} {customer.LastName}";
                textBox10.Text = customer.Age;
                textBox9.Text = customer.ContactNumber;
                textBox7.Text = customer.LicenseNumber;
                textBox8.Text = customer.Email;

                // --- Rental Info ---
                textBox13.Text = rental.RentDatee.ToString("yyyy-MM-dd");
                textBox16.Text = rental.ReturnDate?.ToString("yyyy-MM-dd") ?? "";

                int daysOnRent = rental.ReturnDate.HasValue
                    ? (rental.ReturnDate.Value - rental.RentDatee).Days + 1
                    : (DateTime.Today - rental.RentDatee).Days + 1;

                textBox14.Text = daysOnRent.ToString();
                textBox15.Text = rental.TotalCost?.ToString("F2");

                radioButton1.Checked = rental.ActualReturnDate == null;
                radioButton2.Checked = rental.ActualReturnDate != null;

                if (!string.IsNullOrWhiteSpace(car.ImagePath) && File.Exists(car.ImagePath))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(car.ImagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load car image.\n" + ex.Message);
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}