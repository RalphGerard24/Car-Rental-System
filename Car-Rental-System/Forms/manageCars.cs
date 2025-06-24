using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class ManageCars : Form
    {
        private Admin _currentAdmin;


        public ManageCars(Admin admin) : this()
        {
            _currentAdmin = admin;


            button1.Click += Button1_Click;
        }


        public ManageCars()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellClick;
            SetupFilterEvents();
            PopulateFilters();
            UpdateCarListBasedOnFilters();
            AddEditDeleteButtons();
            button3.Click += button3_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var dashboard = new AdminDashboard(_currentAdmin);
            dashboard.FormClosed += (_, __) => this.Close();
            this.Hide();
            dashboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var customers = new ManageCustomer(_currentAdmin);
            customers.FormClosed += (_, __) => this.Close();
            this.Hide();
            customers.Show();
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
                dataGridView1.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                });
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                });
            }

            if (!dataGridView1.Columns.Contains("View"))
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "View",
                    HeaderText = "View",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                });
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var carId = Convert.ToInt32(row.Cells["CarId"].Value);
            var column = dataGridView1.Columns[e.ColumnIndex].Name;

            if (column == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this car?",
                                    "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CarService.DeleteCar(carId);
                    UpdateCarListBasedOnFilters();
                }
            }
            else if (column == "Edit")
            {
                var car = CarService.GetCarById(carId);
                if (car != null)
                {
                    var editForm = new AddCars(car);
                    editForm.FormClosed += (_, __) => { this.Show(); UpdateCarListBasedOnFilters(); };
                    this.Hide();
                    editForm.Show();
                }
            }

            else if (column == "View")
            {
                using (var db = new CarRentalDbContext())
                {
                    var rental = db.Rentals
                                   .Where(r => r.CarId == carId)
                                   .OrderByDescending(r => r.RentDatee)
                                   .FirstOrDefault();

                    Form viewForm = rental != null
                        ? new CarDetails(rental.RentalId)
                        : new CarDetails(carId, true);

                    viewForm.FormClosed += (_, __) => this.Close();
                    this.Hide();
                    viewForm.Show();
                }
            }

        }

        private void AddNewCarButton_Click(object sender, EventArgs e)
        {
            var AddCarForm = new AddCars();
            AddCarForm.FormClosed += (_, __) => { this.Show(); UpdateCarListBasedOnFilters(); };
            this.Hide();
            AddCarForm.Show();
        }



        private void UpdateCarListBasedOnFilters()
        {
            string selectedBrand = comboBox1.SelectedItem?.ToString();
            string selectedYear = comboBox2.SelectedItem?.ToString();
            bool? isAvailable = radioButton2.Checked ? true
                               : radioButton3.Checked ? false
                               : (bool?)null;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void FilterAvailability_CheckedChanged(object sender, EventArgs e) { }
        private void ManageCar_Loads(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            RentalRecords rentalRecordsForm = new RentalRecords(_currentAdmin);
            rentalRecordsForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            rentalRecordsForm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
