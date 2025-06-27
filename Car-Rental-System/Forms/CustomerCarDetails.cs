using Car_Rental_System.Services;
using Car_Rental_System.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class CustomerCarDetails : Form
    {
        private Customer _currentCustomer;
        private Car _selectedCar;
        private Admin _admin;

        // Constructor - Initializes the CustomerCarDetails form with car, customer, and admin data
        public CustomerCarDetails(Car car, Customer customer, Admin admin)
        {
            InitializeComponent();
            _selectedCar = car;
            _currentCustomer = customer;
            _admin = admin;

            LoadCarData();
        }

        // Button Click Events
        private void button3_Click_1(object sender, EventArgs e)
        {
            CustomerRentStep1 rentForm = new CustomerRentStep1(_currentCustomer, _admin);
            rentForm.Show();
            this.Hide();
        }

        // Private Helper Methods
        private void LoadCarData()
        {
            // Load car information into textboxes
            textBox2.Text = _selectedCar.Model;
            textBox5.Text = _selectedCar.PriceRate.ToString("F2");
            textBox6.Text = _selectedCar.Color;
            textBox4.Text = _selectedCar.PlateNumber;
            textBox3.Text = _selectedCar.DateRegistered.ToShortDateString();
            textBox7.Text = _selectedCar.Brand;

            // Load and properly display car image
            LoadCarImage();
        }

        private void LoadCarImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(_selectedCar.ImagePath) && File.Exists(_selectedCar.ImagePath))
                {
                    // Load the image and set proper display properties
                    using (var originalImage = Image.FromFile(_selectedCar.ImagePath))
                    {
                        pictureBox1.Image = new Bitmap(originalImage);
                    }

                    // Set PictureBox properties for proper image scaling
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Set placeholder or default image if car image not found
                    pictureBox1.Image = null;
                    pictureBox1.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {
                // Handle image loading errors 
                pictureBox1.Image = null;
                pictureBox1.BackColor = Color.LightGray;
                MessageBox.Show($"Error loading car image: {ex.Message}", "Image Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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