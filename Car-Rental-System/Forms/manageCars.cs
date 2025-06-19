using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Car_Rental_System.Forms
{
    public partial class ManageCars : Form
    {
        public ManageCars()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellClick;

            SetupFilterEvents();
            PopulateFilters();
            UpdateCarListBasedOnFilters();

            AddEditDeleteButtons();

        }

        private void SetupFilterEvents()
        {
            comboBox1.SelectedIndexChanged += (s, e) => UpdateCarListBasedOnFilters();
            comboBox2.SelectedIndexChanged += (s, e) => UpdateCarListBasedOnFilters();

            radioButton1.CheckedChanged += (s, e) => UpdateCarListBasedOnFilters();
            radioButton2.CheckedChanged += (s, e) => UpdateCarListBasedOnFilters();
            radioButton3.CheckedChanged += (s, e) => UpdateCarListBasedOnFilters();
        }

        private void AddEditDeleteButtons()
        {

            if (!dataGridView1.Columns.Contains("Edit"))
            {
                var editButton = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editButton);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                var deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButton);
            }

            if (!dataGridView1.Columns.Contains("View"))
            {
                var viewButton = new DataGridViewButtonColumn
                {
                    Name = "View",
                    HeaderText = "View",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(viewButton);
            }
        }

        //DELETE CARS
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var carIdObj = row.Cells["CarId"].Value;

            if (carIdObj == null)
            {
                MessageBox.Show("Car ID not found.");
                return;
            }

            int carId = Convert.ToInt32(carIdObj);

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colName == "Delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this car?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    CarService.DeleteCar(carId);
                    UpdateCarListBasedOnFilters();
                }
            }
            else if (colName == "Edit")
            {
                var car = CarService.GetCarById(carId);
                if (car != null)
                {
                    var editForm = new addCars(car);
                    editForm.FormClosed += (s, args) => { this.Show(); UpdateCarListBasedOnFilters(); };
                    this.Hide();
                    editForm.Show();
                }
            }

            else if (colName == "View")
            {
                using (var db = new CarRentalDbContext())
                {
                    var rental = db.Rentals
                        .Where(r => r.CarId == carId)
                        .OrderByDescending(r => r.RentDatee)
                        .FirstOrDefault(); 

                    if (rental != null)
                    {
                        var viewForm = new carDetails(rental.RentalId);
                        viewForm.Show();
                    }
                    else
                    {
                        var viewForm = new carDetails(carId, true); 
                        viewForm.Show();
                    }
                }
            }


        }

        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
            var addCarForm = new addCars();
            this.Hide();
            addCarForm.FormClosed += (s, args) =>
            {
                this.Show();
                UpdateCarListBasedOnFilters();
            };
            addCarForm.Show();
        }

        private void UpdateCarListBasedOnFilters()
        {
            string selectedBrand = comboBox1.SelectedItem?.ToString();
            string selectedYear = comboBox2.SelectedItem?.ToString();
            bool? isAvailable = null;

            if (radioButton2.Checked) isAvailable = true;
            else if (radioButton3.Checked) isAvailable = false;

            dataGridView1.DataSource = CarService.GetFilteredCars(selectedBrand, selectedYear, isAvailable);
        }


        private void PopulateFilters()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            comboBox1.Items.AddRange(CarService.GetDistinctBrands().ToArray());
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            comboBox2.Items.Add("All");
            comboBox2.Items.AddRange(CarService.GetDistinctYears().ToArray());
            comboBox2.SelectedIndex = 0;

            radioButton1.Checked = true;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FilterAvailability_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManageCar_Loads(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var customers = new customers();
            customers.Show();
            this.Hide();
        }
    }
}
