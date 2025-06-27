using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
   
    /// Form for managing customers in the car rental system
    /// Provides functionality to view, add, delete customers and access customer profiles
    public partial class ManageCustomer : Form
    {
        #region Fields
        private Admin _currentAdmin;
        #endregion

        #region Constructors
        
        /// Constructor with admin parameter - sets up navigation and admin context
        /// <param name="admin">The current admin user for context and navigation</param>
        public ManageCustomer(Admin admin) : this()
        {
            _currentAdmin = admin;
            SetupNavigationEvents();
        }

        /// Default constructor - initializes form components and loads customer data
 
        public ManageCustomer()
        {
            InitializeComponent();
            InitializeDataGrid();
            LoadCustomers();
        }
        #endregion

        #region Form Initialization
        
        /// Sets up navigation button events for admin dashboard navigation
        private void SetupNavigationEvents()
        {
            // Dashboard navigation
            button1.Click += NavigateToDashboard;

            // Manage Cars navigation
            button2.Click += NavigateToManageCars;

            // Rental Records navigation
            button3.Click += button3_Click;
        }

        /// Initializes DataGridView settings and events
        private void InitializeDataGrid()
        {
            dataGridView1.CellClick += dataGridView1_CellClick;

        }
        #endregion

        #region Button Click Events
        /// Add Customer button click handler
      
        private void button5_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomers();
            addCustomerForm.FormClosed += (_, __) => LoadCustomers();
            addCustomerForm.Show();
        }

        /// Navigate to Rental Records
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rentalRecordsForm = new RentalRecords(_currentAdmin);
            rentalRecordsForm.FormClosed += (_, __) => this.Close();
            rentalRecordsForm.ShowDialog();

        }
        /// Navigate to Admin Dashboard
        private void NavigateToDashboard(object sender, EventArgs e)
        {
            var dashboardForm = new AdminDashboard(_currentAdmin);
            dashboardForm.FormClosed += (_, __) => this.Close();
            this.Hide();
            dashboardForm.Show();
        }

        /// Navigate to Manage Cars form
        private void NavigateToManageCars(object sender, EventArgs e)
        {
            var manageCarsForm = new ManageCars(_currentAdmin);
            manageCarsForm.FormClosed += (_, __) => this.Close();
            this.Hide();
            manageCarsForm.Show();
        }
        #endregion

        #region DataGridView Events
     
        /// Handles cell clicks in the customer data grid
        /// Processes Delete and View Customer button clicks
     
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

        /// Handles customer deletion with confirmation
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

        /// Handles viewing customer profile
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyFont(this, FontManager.GlobalFont); // ← use the shared global font
        }

        private void ApplyFont(Control parent, Font font)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Keep size and style, only change font family
                ctrl.Font = new Font(font.FontFamily, ctrl.Font.Size, ctrl.Font.Style);

                if (ctrl.HasChildren)
                    ApplyFont(ctrl, font);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginPage loginForm = new LoginPage();
            loginForm.Show();

            this.Close();
        }
    }
}