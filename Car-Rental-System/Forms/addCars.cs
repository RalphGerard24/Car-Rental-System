using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class addCars : Form
    {
        private string selectedImagePath = string.Empty; // To store the path of the selected image
        private string savedImagePath = string.Empty;
        public addCars()
        {
            InitializeComponent();
            this.button2.Click += new System.EventHandler(this.saveCarButton_Click);
            this.button1.Click += new EventHandler(this.uploadImageButton_Click);


        }

        //Editing constructor to handle editing an existing car
        private Car EditingCar;
        public addCars(Car carToEdit) : this()
        {
            EditingCar = carToEdit;
            this.Text = "Edit Car";

            MessageBox.Show("Editing Car ID: " + EditingCar.CarId);

            textBox2.Text = carToEdit.Model;
            textBox4.Text = carToEdit.Brand;
            textBox6.Text = carToEdit.PlateNumber;
            textBox3.Text = carToEdit.Year;
            textBox5.Text = carToEdit.Color;
            textBox7.Text = carToEdit.PriceRate.ToString();
            dateTimePicker1.Value = carToEdit.DateRegistered;
            selectedImagePath = Path.Combine(Application.StartupPath, carToEdit.ImagePath);

            if (File.Exists(selectedImagePath))
            {
                pictureBox1.Image = Image.FromFile(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void saveCarButton_Click(object sender, EventArgs e)
        {
            // --- Field Presence Check ---
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||  // Model
                string.IsNullOrWhiteSpace(textBox4.Text) ||  // Brand
                string.IsNullOrWhiteSpace(textBox6.Text) ||  // Plate Number
                string.IsNullOrWhiteSpace(textBox3.Text) ||  // Year
                string.IsNullOrWhiteSpace(textBox5.Text) ||  // Color
                string.IsNullOrWhiteSpace(textBox7.Text))    // Price
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            // --- Integer Validations ---
            if (!int.TryParse(textBox3.Text, out int year))
            {
                MessageBox.Show("Year must be a valid number.");
                return;
            }

            if (!int.TryParse(textBox7.Text, out int priceRate) || priceRate <= 0)
            {
                MessageBox.Show("Price Rate must be a positive number.");
                return;
            }

            // --- Color Validation ---
            if (!textBox5.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Color must only contain letters and spaces.");
                return;
            }

            using (var db = new CarRentalDbContext())
            {
                bool plateExists = db.Cars.Any(c =>
                    c.PlateNumber == textBox6.Text &&
                    (EditingCar == null || c.CarId != EditingCar.CarId)); // Exclude current car when editing

                if (plateExists)
                {
                    MessageBox.Show("A car with this Plate Number already exists.");
                    return;
                }
            }


            // --- Image validation ---
            if (string.IsNullOrWhiteSpace(selectedImagePath) || !File.Exists(selectedImagePath))
            {
                MessageBox.Show("Please attach a valid car image.");
                return;
            }

            try
            {
                // Save image to Images folder
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(imagesFolder);

                string imageFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
                savedImagePath = Path.Combine(imagesFolder, imageFileName);
                File.Copy(selectedImagePath, savedImagePath, true);

                string imagePathForDatabase = Path.Combine("Images", imageFileName);

                // Create Car 
                var car = new Car
                {
                    Model = textBox2.Text,
                    Brand = textBox4.Text,
                    PlateNumber = textBox6.Text,
                    Year = year.ToString(),
                    Color = textBox5.Text,
                    PriceRate = priceRate,
                    DateRegistered = dateTimePicker1.Value,
                    ImagePath = imagePathForDatabase,
                    IsAvailable = true
                };

                if (EditingCar != null)
                {
                    car.CarId = EditingCar.CarId; 
                    CarService.UpdateCar(car);
                    MessageBox.Show("Car updated in database.");
                }
                else
                {
                    CarService.AddCar(car);
                    MessageBox.Show("Car added successfully!");
                }

                var manageForm = new ManageCars();
                manageForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving car:\n" + ex.Message);
            }

        }

        //upload image button click event
        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select Car Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addCars_Load(object sender, EventArgs e)
        { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { }
        private void groupBox1_Enter(object sender, EventArgs e)
        { }
        private void textBox2_TextChanged(object sender, EventArgs e)
        { }
        private void label6_Click(object sender, EventArgs e)
        { }

    }
}
