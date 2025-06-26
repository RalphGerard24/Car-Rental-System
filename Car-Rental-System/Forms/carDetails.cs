using Car_Rental_System.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class CarDetails : Form
    {
        private int? _rentalId;
        private int? _carId;

        // Constructor - Initialize form with rental ID
        public CarDetails(int rentalId)
        {
            InitializeComponent();
            _rentalId = rentalId;
            this.FormClosing += CarDetails_FormClosing;
        }

        // Constructor - Initialize form with car ID for direct car view
        public CarDetails(int carId, bool directCarView)
        {
            InitializeComponent();
            _carId = carId;
            this.FormClosing += CarDetails_FormClosing;
        }

        // Form Event Handlers
        private void CarDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            var manageCarsForm = new ManageCars();
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {
            LoadCarAndRentalData();
        }

        // Button Click Events
        private void button3_Click(object sender, EventArgs e)
        {
            var manageCars = new ManageCars();
            manageCars.Show();
            this.Close();
        }

        // Private Helper Methods
        private void LoadCarAndRentalData()
        {
            using var db = new CarRentalDbContext();
            Rental rental = null;

            // Determine rental based on provided ID
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

            // Get car and customer information
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
                MessageBox.Show("Car not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadCarInformation(car);

            if (rental != null && customer != null)
            {
                LoadCustomerInformation(customer);
                LoadRentalInformation(rental);
            }
        }

        private void LoadCarInformation(Car car)
        {
            textBox1.Text = car.CarId.ToString();
            textBox2.Text = car.Model;
            textBox4.Text = car.Brand;
            textBox5.Text = car.Color;
            textBox6.Text = car.PlateNumber;
            textBox3.Text = car.DateRegistered.ToString("yyyy-MM-dd");

            LoadCarImage(car.ImagePath);
        }

        private void LoadCustomerInformation(Customer customer)
        {
            textBox12.Text = customer.CustomerId.ToString();
            textBox11.Text = $"{customer.FirstName} {customer.LastName}";
            textBox10.Text = customer.Age;
            textBox9.Text = customer.ContactNumber;
            textBox7.Text = customer.LicenseNumber;
            textBox8.Text = customer.Email;
        }

        private void LoadRentalInformation(Rental rental)
        {
            textBox13.Text = rental.RentDatee.ToString("yyyy-MM-dd");
            textBox16.Text = rental.ReturnDate?.ToString("yyyy-MM-dd") ?? "";

            // Calculate days on rent
            int daysOnRent = rental.ReturnDate.HasValue
                ? (rental.ReturnDate.Value - rental.RentDatee).Days + 1
                : (DateTime.Today - rental.RentDatee).Days + 1;

            textBox14.Text = daysOnRent.ToString();
            textBox15.Text = rental.TotalCost?.ToString("F2") ?? "0.00";

            // Set rental status radio buttons
            radioButton1.Checked = rental.ActualReturnDate == null;
            radioButton2.Checked = rental.ActualReturnDate != null;
        }

        private void LoadCarImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // Load the image and set proper display properties
                    using (var originalImage = Image.FromFile(imagePath))
                    {
                        pictureBox1.Image = new Bitmap(originalImage);
                    }

                    // Set PictureBox properties for proper image scaling
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Set placeholder when image not found
                    pictureBox1.Image = null;
                    pictureBox1.BackColor = Color.LightGray;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                // Handle image loading errors gracefully
                pictureBox1.Image = null;
                pictureBox1.BackColor = Color.LightGray;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show($"Unable to load car image: {ex.Message}", "Image Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

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