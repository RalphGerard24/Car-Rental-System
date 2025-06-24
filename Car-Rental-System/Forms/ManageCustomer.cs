using Car_Rental_System.Models;
using Car_Rental_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class ManageCustomer : Form
    {
        private Admin _currentAdmin;  

        public ManageCustomer(Admin admin) : this()    
        {
            _currentAdmin = admin;


            button1.Click += (s, e) =>
            {
                var dash = new AdminDashboard(_currentAdmin);
                dash.FormClosed += (_, __) =>
                {
                    Console.WriteLine("Closing ManageCustomer...");
                    this.Close();                     
                };
                this.Hide();                           
                dash.Show();                           
            };

            button2.Click += (s, e) =>
            {
                var cars = new ManageCars(_currentAdmin);
                cars.FormClosed += (_, __) =>
                {
                    Console.WriteLine("Closing ManageCustomer...");
                    this.Close();
                };
                this.Hide();
                cars.Show();
            };

        }

        public ManageCustomer()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadCustomers();                
        }


        private void button5_Click(object sender, EventArgs e)
        {
            var add = new AddCustomers();
            add.FormClosed += (_, __) =>
            {
                this.Show();
                LoadCustomers();
            };
            this.Hide();
            add.Show();
        }


        private void LoadCustomers()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = CustomerService.GetAllCustomers();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            int customerId = Convert.ToInt32(
                                   dataGridView1.Rows[e.RowIndex]
                                   .Cells["CustomerId"].Value);
            string column = dataGridView1.Columns[e.ColumnIndex].Name;

            if (column == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?",
                                    "Confirm Deletion",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    CustomerService.DeleteCustomer(customerId);
                    LoadCustomers();
                }
            }
            else if (column == "ViewDashboard")
            {
                var customer = CustomerService.GetCustomerById(customerId);
                if (customer != null)
                {
                    var profile = new CustomerProfile(customer, _currentAdmin);
                    profile.FormClosed += (_, __) => this.Show();
                    this.Hide();
                    profile.Show();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
