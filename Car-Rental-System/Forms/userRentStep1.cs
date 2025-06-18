using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class userRentStep1 : Form
    {
        private Customer customerSelected;
        private Car _selectedCar;
      

        public userRentStep1(Customer customer)
        {
            InitializeComponent();
            customerSelected = customer;
            LoadAvailableCars();
            LoadBrandFilter(); 
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }
        //list ng car na available
        private List<Car> LoadAvailableCarsFromDb()
        {
            using (var list= new CarRentalDbContext())
            {
                return list.Cars.Where(c => c.IsAvailable).ToList();
            }
        }
        //dynamic for box
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
                viewBtn.Click += button8_Click_1;

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
        }
        //view car details button
        private void button8_Click_1(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                Car selectedCar = clickedBtn.Tag as Car;
                if (selectedCar != null)
                {
                    userCarDetails detailsForm = new userCarDetails(selectedCar, customerSelected);
                    detailsForm.Show();
                    this.Hide();
                }
            }
        }

        //proceed button
        private void button6_Click(object sender, EventArgs e)
        {
            if (_selectedCar != null)
            {
                var rentForm2 = new userRentStep2(customerSelected, _selectedCar);
                rentForm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a car before proceeding.", "No Car Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //filter by brand
        private void LoadBrandFilter()
        {
            using (var brandcar = new CarRentalDbContext())
            {
                var brands = brandcar.Cars
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = comboBox1.SelectedItem.ToString();
            LoadAvailableCars(selectedBrand);
        }


        private void button5_Click(object sender, EventArgs e){}

        private void pictureBox2_Click(object sender, EventArgs e){ }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}


    }
}
