using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    /// <summary>
    /// Form for managing customers in the car rental system
    /// Provides functionality to view, add, delete customers and access customer profiles
    /// </summary>
    public partial class ManageCustomer : Form
    {
        #region Fields
        private Admin _currentAdmin;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor with admin parameter - sets up navigation and admin context
        /// </summary>
        /// <param name="admin">The current admin user for context and navigation</param>
        public ManageCustomer(Admin admin) : this()
        {
            _currentAdmin = admin;
            SetupNavigationEvents();
        }

        /// <summary>
        /// Default constructor - initializes form components and loads customer data
        /// </summary>
        public ManageCustomer()
        {
            InitializeComponent();
            InitializeDataGrid();
            LoadCustomers();
        }
        #endregion

        #region Form Initialization
        /// <summary>
        /// Sets up navigation button events for admin dashboard navigation
        /// </summary>
        private void SetupNavigationEvents()
        {
            // Dashboard navigation
            button1.Click += NavigateToDashboard;

            // Manage Cars navigation
            button2.Click += NavigateToManageCars;

            // Rental Records navigation
            button3.Click += button3_Click;
        }

        /// <summary>
        /// Initializes DataGridView settings and events
        /// </summary>
        private void InitializeDataGrid()
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
            comboBoxAge.SelectedIndexChanged += (s, e) => ApplyFilters();
            comboBoxCity.SelectedIndexChanged += (s, e) => ApplyFilters();

        }
        #endregion

        #region Button Click Events
        /// <summary>
        /// Add Customer button click handler
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomers();
            addCustomerForm.FormClosed += (_, __) => LoadCustomers();
            addCustomerForm.Show();
        }

        /// <summary>
        /// Navigate to Rental Records
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            var rentalRecordsForm = new RentalRecords(_currentAdmin);
            rentalRecordsForm.FormClosed += (_, __) => this.Close();
            this.Hide();
            rentalRecordsForm.Show();
        }

        /// <summary>
        /// Navigate to Admin Dashboard
        /// </summary>
        private void NavigateToDashboard(object sender, EventArgs e)
        {
            var dashboardForm = new AdminDashboard(_currentAdmin);
            dashboardForm.FormClosed += (_, __) => this.Close();
            this.Hide();
            dashboardForm.Show();
        }

        /// <summary>
        /// Navigate to Manage Cars form
        /// </summary>
        private void NavigateToManageCars(object sender, EventArgs e)
        {
            var manageCarsForm = new ManageCars(_currentAdmin);
            manageCarsForm.FormClosed += (_, __) => this.Close();
            this.Hide();
            manageCarsForm.Show();
        }
        #endregion

        #region DataGridView Events
        /// <summary>
        /// Handles cell clicks in the customer data grid
        /// Processes Delete and View Customer button clicks
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validate row and column selection
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            try
            {
                // Get customer ID from selected row
                int customerId = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);

                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "Delete":
                        HandleDeleteCustomer(customerId);
                        break;
                    case "ViewDashboard":
                        HandleViewCustomer(customerId);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing request: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Helper Methods
        /// <summary>
        /// Loads all customers into the DataGridView and sets up action columns
        /// </summary>
        /// 
        private void ApplyFilters()
        {
            string selectedCity = comboBoxCity.SelectedItem?.ToString();
            string selectedAgeStr = comboBoxAge.SelectedItem?.ToString();

            int? selectedAge = null;

            if (int.TryParse(selectedAgeStr, out int parsedAge))
                selectedAge = parsedAge;

            var filteredCustomers = CustomerService.GetFilteredCustomers(selectedAge, selectedCity);
            dataGridView1.DataSource = filteredCustomers;
        }

        private void LoadCustomers()
        {
            try
            {
                // Clear existing columns and reload data
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = CustomerService.GetAllCustomers();

                // Add Delete button column if not exists
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

                // Add View Customer button column if not exists
                if (!dataGridView1.Columns.Contains("ViewDashboard"))
                {
                    dataGridView1.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "ViewDashboard",
                        HeaderText = "Customer Info",
                        Text = "View Customer",
                        UseColumnTextForButtonValue = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles customer deletion with confirmation
        /// </summary>
        /// <param name="customerId">ID of customer to delete</param>
        private void HandleDeleteCustomer(int customerId)
        {
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    CustomerService.DeleteCustomer(customerId);
                    LoadCustomers(); // Refresh the grid
                    MessageBox.Show("Customer deleted successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles viewing customer profile
        /// </summary>
        /// <param name="customerId">ID of customer to view</param>
        private void HandleViewCustomer(int customerId)
        {
            try
            {
                var customer = CustomerService.GetCustomerById(customerId);
                if (customer != null)
                {
                    var customerProfile = new CustomerProfile(customer, _currentAdmin);
                    customerProfile.FormClosed += (_, __) => this.Show();
                    this.Hide();
                    customerProfile.Show();
                }
                else
                {
                    MessageBox.Show("Customer not found.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Empty Event Handlers (Required for Designer)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        #endregion

        private void ManageCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}