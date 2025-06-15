using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadCustomers(); // Load data initially
        }

        private void button5_Click(object sender, EventArgs e) // Add Customer Button
        {
            var addCustomerForm = new AddCustomer();
            this.Hide();

            addCustomerForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadCustomers(); // Refresh after adding
            };

            addCustomerForm.Show();
        }

        private void LoadCustomers()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = CustomerService.GetAllCustomers();

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

            if (!dataGridView1.Columns.Contains("ViewDashboard"))
            {
                var dashboardButton = new DataGridViewButtonColumn
                {
                    Name = "ViewDashboard",
                    HeaderText = "Dashboard",
                    Text = "View Dashboard",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(dashboardButton);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int customerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);

            // Handle Delete
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this customer?",
                                              "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    CustomerService.DeleteCustomer(customerId);
                    LoadCustomers(); // Refresh grid
                }
            }

            // Handle View Dashboard
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ViewDashboard")
            {
                var customer = CustomerService.GetCustomerById(customerId);
                if (customer != null)
                {
                    var userDashboard = new userDashboard(customer);
                    this.Hide();
                    userDashboard.FormClosed += (s, args) => this.Show();
                    userDashboard.Show();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

    }
}
