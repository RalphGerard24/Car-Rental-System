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

        private void addCars_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            // Validate Input fields
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                !double.TryParse(textBox7.Text, out double price))
            {
                MessageBox.Show("Please fill all required fields correctly.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedImagePath) || !File.Exists(selectedImagePath))
            {
                MessageBox.Show("Please attach a valid car image.");
                return;
            }

            // Save image to local folder + validations
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            Directory.CreateDirectory(imagesFolder);

            string imageFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath);
            savedImagePath = Path.Combine(imagesFolder, imageFileName);
            File.Copy(selectedImagePath, savedImagePath, true);

            string imagePathForDatabase = Path.Combine("Images", imageFileName);

            //Update or Add Car to Database
            try
            {
                using var db = new CarRentalDbContext();

                if (EditingCar != null)
                {
                    var car = db.Cars.FirstOrDefault(c => c.CarId == EditingCar.CarId);
                    if (car != null)
                    {
                        car.Model = textBox2.Text;
                        car.Brand = textBox4.Text;
                        car.PlateNumber = textBox6.Text;
                        car.Year = textBox3.Text;
                        car.Color = textBox5.Text;
                        car.PriceRate = price;
                        car.DateRegistered = dateTimePicker1.Value;
                        car.ImagePath = imagePathForDatabase;
                        car.IsAvailable = true;

                        db.SaveChanges();
                        MessageBox.Show(" Car updated in database.");
                    }
                    else
                    {
                        MessageBox.Show(" Could not find car with CarId: " + EditingCar.CarId);
                    }
                }
                else
                {
                    var newCar = new Car
                    {
                        Model = textBox2.Text,
                        Brand = textBox4.Text,
                        PlateNumber = textBox6.Text,
                        Year = textBox3.Text,
                        Color = textBox5.Text,
                        PriceRate = price,
                        DateRegistered = dateTimePicker1.Value,
                        ImagePath = imagePathForDatabase,
                        IsAvailable = true
                    };

                    CarService.AddCar(newCar);
                    MessageBox.Show("Car added successfully!");
                }

                //Proceed to manage cars form after adding or editing
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

    }
}
