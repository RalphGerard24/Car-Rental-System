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

        // Constructor - Initializes the manage cars form with admin context
        public ManageCars(Admin admin) : this()
        {
            _currentAdmin = admin;
            SetupAdminEventHandlers();
        }

        // Default constructor for design-time support
        public ManageCars()
        {
            InitializeComponent();
            InitializeForm();
        }

        // Form Event Handlers
        private void ManageCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form cleanup handled automatically
        }

        // Button Click Events
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            NavigateToAdminDashboard();
        }

        private void buttonManageCustomers_Click(object sender, EventArgs e)
        {
            NavigateToManageCustomers();
        }

        private void buttonRentalRecords_Click(object sender, EventArgs e)
        {
            NavigateToRentalRecords();
        }

        private void buttonAddNewCar_Click(object sender, EventArgs e)
        {
            NavigateToAddCarForm();
        }

        // Value Changed / UI Events
        private void brandFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCarListBasedOnFilters();
        }

        private void yearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCarListBasedOnFilters();
        }

        private void availabilityFilter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCarListBasedOnFilters();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleDataGridCellClick(e);
        }

        // Private Helper Methods
        private void InitializeForm()
        {
            SetupFilterEvents();
            PopulateFilters();
            UpdateCarListBasedOnFilters();
            AddActionButtons();
            SetupDataGridEvents();
        }

        private void SetupAdminEventHandlers()
        {
            button1.Click += buttonDashboard_Click;
            button4.Click += buttonManageCustomers_Click;
            button3.Click += buttonRentalRecords_Click;
            button6.Click += buttonAddNewCar_Click;
        }

        private void SetupFilterEvents()
        {
            comboBox1.SelectedIndexChanged += brandFilter_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += yearFilter_SelectedIndexChanged;
            radioButton1.CheckedChanged += availabilityFilter_CheckedChanged;
            radioButton2.CheckedChanged += availabilityFilter_CheckedChanged;
            radioButton3.CheckedChanged += availabilityFilter_CheckedChanged;
        }

        private void SetupDataGridEvents()
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void AddActionButtons()
        {
            AddButtonColumn("Edit", "Edit");
            AddButtonColumn("Delete", "Delete");
            AddButtonColumn("View", "View");
        }

        private void AddButtonColumn(string name, string headerText)
        {
            if (!dataGridView1.Columns.Contains(name))
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = name,
                    HeaderText = headerText,
                    Text = headerText,
                    UseColumnTextForButtonValue = true
                });
            }
        }

        private void HandleDataGridCellClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var carId = Convert.ToInt32(row.Cells["CarId"].Value);
            var columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "Delete":
                    HandleDeleteAction(carId);
                    break;
                case "Edit":
                    HandleEditAction(carId);
                    break;
                case "View":
                    HandleViewAction(carId);
                    break;
            }
        }

        private void HandleDeleteAction(int carId)
        {
            var result = MessageBox.Show("Are you sure you want to delete this car?",
                                       "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CarService.DeleteCar(carId);
                UpdateCarListBasedOnFilters();
                MessageBox.Show("Car deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HandleEditAction(int carId)
        {
            var car = CarService.GetCarById(carId);
            if (car != null)
            {
                var editForm = new AddCars(car);
                editForm.FormClosed += (_, __) => { this.Show(); UpdateCarListBasedOnFilters(); };
                editForm.Show();
                this.Hide();
            }
        }

        private void HandleViewAction(int carId)
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
                viewForm.Show();
                this.Hide();
            }
        }

        private void UpdateCarListBasedOnFilters()
        {
            string selectedBrand = GetSelectedFilterValue(comboBox1);
            string selectedYear = GetSelectedFilterValue(comboBox2);
            bool? isAvailable = GetAvailabilityFilter();

            dataGridView1.DataSource = CarService.GetFilteredCars(selectedBrand, selectedYear, isAvailable);
        }

        private string GetSelectedFilterValue(ComboBox comboBox)
        {
            var selectedValue = comboBox.SelectedItem?.ToString();
            return selectedValue == "All" ? null : selectedValue;
        }

        private bool? GetAvailabilityFilter()
        {
            if (radioButton2.Checked) return true;
            if (radioButton3.Checked) return false;
            return null;
        }

        private void PopulateFilters()
        {
            PopulateBrandFilter();
            PopulateYearFilter();
            SetDefaultFilters();
        }

        private void PopulateBrandFilter()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("All");
            comboBox1.Items.AddRange(CarService.GetDistinctBrands().ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void PopulateYearFilter()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("All");
            comboBox2.Items.AddRange(CarService.GetDistinctYears().ToArray());
            comboBox2.SelectedIndex = 0;
        }

        private void SetDefaultFilters()
        {
            radioButton1.Checked = true;
        }

        private void NavigateToAdminDashboard()
        {
            var dashboard = new AdminDashboard(_currentAdmin);
            dashboard.FormClosed += (_, __) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void NavigateToManageCustomers()
        {
            var customers = new ManageCustomer(_currentAdmin);
            customers.FormClosed += (_, __) => this.Close();
            customers.Show();
            this.Hide();
        }

        private void NavigateToRentalRecords()
        {
            var rentalRecords = new RentalRecords(_currentAdmin);
            rentalRecords.FormClosed += (_, __) => this.Close();
            rentalRecords.Show();
            this.Hide();
        }

        private void NavigateToAddCarForm()
        {
            var addCarForm = new AddCars();
            addCarForm.FormClosed += (_, __) => { this.Show(); UpdateCarListBasedOnFilters(); };
            addCarForm.Show();
            this.Hide();
        }
    }
}