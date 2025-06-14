using Car_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class customers : Form
    {
        public customers()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadCustomers(); // Call to load data initially
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event handler is often not used for button clicks. CellClick is more appropriate.
        }

        private void button5_Click(object sender, EventArgs e) // Add Customer Button
        {
            var addCustomerForm = new AddCustomer();
            this.Hide();

            addCustomerForm.FormClosed += (s, args) =>
            {
                this.Show(); // Show ManageCustomers again
                RefCustomers(); // Refresh the customer list in case a new one was added
            };

            addCustomerForm.Show();
        }

        private void RefCustomers()
        {
            LoadCustomers(); // Call LoadCustomers to refresh the grid
        }

        // Load Customers into DataGridView
        private void LoadCustomers()
        {
            using (var db = new CarRentalDbContext())
            {
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true; // Automatically create columns from Customer properties
                dataGridView1.DataSource = db.Customers.ToList(); // Fetch all customers

                // Add Delete button column
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
        }

        // Handle Delete button clicks in the DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore clicks on the header row

            // Handle Delete button click
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int customerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value); // Ensure "CustomerId" column exists in your grid

                var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using var db = new CarRentalDbContext();
                    var customerToDelete = db.Customers.Find(customerId);
                    if (customerToDelete != null)
                    {
                        db.Customers.Remove(customerToDelete);
                        db.SaveChanges();
                        LoadCustomers(); // Refresh the grid after deletion
                    }
                }
            }
        }
    }
}