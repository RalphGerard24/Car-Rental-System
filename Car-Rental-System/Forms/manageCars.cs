using Car_Rental_System.Models;
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
        }


        //EDIT CARS
        private void LoadCars()
        {
            using (var db = new CarRentalDbContext())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = db.Cars.ToList();
            }

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
        }


        //DELETE CARS
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int carId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CarId"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this car?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using var db = new CarRentalDbContext();
                    var carToDelete = db.Cars.Find(carId);
                    if (carToDelete != null)
                    {
                        db.Cars.Remove(carToDelete);
                        db.SaveChanges();
                        LoadCars();
                    }
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                int carId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CarId"].Value);
                using var db = new CarRentalDbContext();
                var car = db.Cars.Find(carId);
                if (car != null)
                {
                    var editForm = new addCars(car);
                    editForm.FormClosed += (s, args) => { this.Show(); LoadCars(); };
                    this.Hide();
                    editForm.Show();
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
                LoadCars();
            };
            addCarForm.Show();
        }
        private void UpdateCarListBasedOnFilters()
        {
            using var db = new CarRentalDbContext();
            var query = db.Cars.AsQueryable();

            // Brand filter
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() != "All")
            {
                query = query.Where(c => c.Brand == comboBox1.SelectedItem.ToString());
            }

            // Year filter
            if (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() != "All")
            {
                query = query.Where(c => c.Year == comboBox2.SelectedItem.ToString());
            }

            // Availability filter
            if (radioButton2.Checked) // Available
            {
                query = query.Where(c => c.IsAvailable);
            }
            else if (radioButton3.Checked) // Rented
            {
                query = query.Where(c => !c.IsAvailable);
            }

            dataGridView1.DataSource = query.ToList();
        }

        private void PopulateFilters()
        {
            using var db = new CarRentalDbContext();

            // Brand
            var brands = db.Cars.Select(c => c.Brand).Distinct().ToList();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            comboBox1.Items.AddRange(brands.ToArray());
            comboBox1.SelectedIndex = 0;

            // Year
            var years = db.Cars.Select(c => c.Year).Distinct().ToList();
            comboBox2.Items.Clear();
            comboBox2.Items.Add("All");
            comboBox2.Items.AddRange(years.ToArray());
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
    }
}
