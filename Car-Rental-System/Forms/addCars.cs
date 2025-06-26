using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class AddCars : Form
    {
        private string selectedImagePath = string.Empty;
        private string savedImagePath = string.Empty;
        private Car EditingCar;

        // Constructor for Add mode
        public AddCars()
        {
            InitializeComponent();
            this.button2.Click += saveCarButton_Click;
            this.button1.Click += uploadImageButton_Click;
        }

        // Constructor for Edit mode
        public AddCars(Car carToEdit) : this()
        {
            EditingCar = carToEdit;
            this.Text = "Edit Car";

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

        // Save/Add/Update Car Button
        private void saveCarButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields()) return;

            if (!int.TryParse(textBox3.Text, out int year) ||
                !int.TryParse(textBox7.Text, out int priceRate) || priceRate <= 0)
            {
                MessageBox.Show("Year and Price must be valid numbers.");
                return;
            }

            if (!textBox5.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Color must only contain letters and spaces.");
                return;
            }

            if (!IsValidPlateNumberFormat(textBox6.Text.ToUpper()))
            {
                MessageBox.Show("Invalid Plate Number format. Format must be 'LLL DDDD'.");
                return;
            }

            if (!ValidateImage()) return;

            if (!ValidatePlateNumberUniqueness()) return;

            try
            {
                string imagePathForDatabase = SaveImageFile();

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
                    MessageBox.Show("Car updated successfully.");
                }
                else
                {
                    CarService.AddCar(car);
                    MessageBox.Show("New car added successfully.");
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

        // Upload Image Button
        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select Car Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // Validation Helpers
        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private bool ValidateImage()
        {
            if (string.IsNullOrWhiteSpace(selectedImagePath) || !File.Exists(selectedImagePath))
            {
                MessageBox.Show("Please attach a valid car image.");
                return false;
            }
            return true;
        }

        private bool ValidatePlateNumberUniqueness()
        {
            using var db = new CarRentalDbContext();
            bool plateExists = db.Cars.Any(c =>
                c.PlateNumber == textBox6.Text &&
                (EditingCar == null || c.CarId != EditingCar.CarId));

            if (plateExists)
            {
                MessageBox.Show("Plate Number already exists.");
                return false;
            }
            return true;
        }

        private bool IsValidPlateNumberFormat(string plate)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(plate, @"^[A-Z]{3} \d{4}$");
        }


        private string SaveImageFile()
        {
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            Directory.CreateDirectory(imagesFolder);

            string imageFileName = Guid.NewGuid() + Path.GetExtension(selectedImagePath);
            savedImagePath = Path.Combine(imagesFolder, imageFileName);
            File.Copy(selectedImagePath, savedImagePath, true);

            return Path.Combine("Images", imageFileName);
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

        private void AddCars_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
