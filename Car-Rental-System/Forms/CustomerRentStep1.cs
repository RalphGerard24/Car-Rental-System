using Car_Rental_System.Forms;
using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace Car_Rental_System
{
    public partial class CustomerRentStep1 : Form
    {
        private Customer customerSelected;
        private Car _selectedCar;
        private Admin _admin;

        public CustomerRentStep1(Customer customer, Admin admin)
        {
            InitializeComponent();
            customerSelected = customer;
            _admin = admin;

            InitializeEventHandlers();
            LoadAvailableCars();
            LoadBrandFilter();
        }

        private void InitializeEventHandlers()
        {
            this.FormClosing += CustomerRentStep1_FormClosing;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += BackToProfileButton_Click;
            button3.Click += BackToAdminButton_Click;
            button4.Click += ReturnCarButton_Click;
            button6.Click += ProceedButton_Click;
        }

        // Form Event Handlers
        private void CustomerRentStep1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                var result = MessageBox.Show(
                    "You have selected a car. Are you sure you want to go back to your Profile without proceeding?",
                    "Confirm Navigation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }

            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                var profileForm = new CustomerProfile(customerSelected, _admin);
                profileForm.Show();
            }
        }

        // Button Click Events
        private void BackToProfileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var result = MessageBox.Show(
                    "You have selected a car. Are you sure you want to go back to the Profile without proceeding?",
                    "Confirm Navigation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }

            var profileForm = new CustomerProfile(customerSelected, _admin);
            profileForm.Show();
            this.Hide();
        }

        private void BackToAdminButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var result = MessageBox.Show(
                    "You have selected a car. Are you sure you want to go back to the Admin view (Manage Customers)?",
                    "Confirm Navigation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }

            var manageCustomerForm = new ManageCustomer(_admin);
            this.Hide();
            manageCustomerForm.Show();
        }

        private void ReturnCarButton_Click(object sender, EventArgs e)
        {
            using (var db = new CarRentalDbContext())
            {
                var ongoingRental = db.Rentals
                    .FirstOrDefault(r => r.CustomerId == customerSelected.CustomerId &&
                                         r.ActualReturnDate == null);

                if (ongoingRental != null)
                {
                    var returnForm = new CustomerReturn(customerSelected.CustomerId, ongoingRental.CarId, _admin);
                    returnForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No active rental found to return.", "Return Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (_selectedCar != null)
            {
                using (var db = new CarRentalDbContext())
                {
                    bool hasActiveRental = db.Rentals.Any(r =>
                        r.CustomerId == customerSelected.CustomerId &&
                        r.ActualReturnDate == null);

                    if (hasActiveRental)
                    {
                        MessageBox.Show("You already have an active rental. Please return your current car before renting another.",
                            "Rental Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                var rentForm2 = new CustomerRentStep2(customerSelected, _selectedCar, _admin);
                rentForm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a car before proceeding.", "No Car Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewCarDetailsButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn?.Tag is Car selectedCar)
            {
                CustomerCarDetails detailsForm = new CustomerCarDetails(selectedCar, customerSelected, _admin);
                detailsForm.Show();
                this.Hide();
            }
        }

        // UI Events
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = comboBox1.SelectedItem.ToString();
            LoadAvailableCars(selectedBrand);
        }

        // Private Helper Methods
        private List<Car> LoadAvailableCarsFromDb()
        {
            using (var context = new CarRentalDbContext())
            {
                return context.Cars.Where(c => c.IsAvailable).ToList();
            }
        }

        private void LoadAvailableCars(string selectedBrand = "All")
        {
            var cars = LoadAvailableCarsFromDb();

            if (selectedBrand != "All")
            {
                cars = cars.Where(c => c.Brand == selectedBrand).ToList();
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (var car in cars)
            {
                CreateCarPanel(car);
            }
        }

        private void CreateCarPanel(Car car)
        {
            Panel carPanel = new Panel
            {
                Width = 200,
                Height = 260,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            PictureBox carPictureBox = new PictureBox
            {
                Width = 180,
                Height = 120,
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (!string.IsNullOrEmpty(car.ImagePath) && File.Exists(car.ImagePath))
            {
                carPictureBox.Image = Image.FromFile(car.ImagePath);
            }

            Label carLabel = new Label
            {
                Text = $"{car.Brand} {car.Model}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 180,
                Height = 30,
                Location = new Point(10, 140),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            Button viewBtn = new Button
            {
                Text = "View Car Details",
                Width = 180,
                Height = 30,
                Location = new Point(10, 175),
                Tag = car
            };
            viewBtn.Click += ViewCarDetailsButton_Click;

            Button selectBtn = new Button
            {
                Text = "Select",
                Width = 180,
                Height = 30,
                Location = new Point(10, 210),
                Tag = car
            };
            selectBtn.Click += (s, e) =>
            {
                _selectedCar = (Car)((Button)s).Tag;
                textBox1.Text = $"{_selectedCar.Brand} {_selectedCar.Model}";
            };

            carPanel.Controls.Add(carPictureBox);
            carPanel.Controls.Add(carLabel);
            carPanel.Controls.Add(viewBtn);
            carPanel.Controls.Add(selectBtn);

            flowLayoutPanel1.Controls.Add(carPanel);
        }

        private void LoadBrandFilter()
        {
            using (var context = new CarRentalDbContext())
            {
                var brands = context.Cars
                    .Where(c => c.IsAvailable)
                    .Select(c => c.Brand)
                    .Distinct()
                    .OrderBy(b => b)
                    .ToList();

                comboBox1.Items.Clear();
                comboBox1.Items.Add("All");
                comboBox1.Items.AddRange(brands.ToArray());
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
