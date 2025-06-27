using Car_Rental_System.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class RentalRecords : Form
    {
        private CarRentalDbContext _context;
        private readonly Admin _currentAdmin;

        // Constructor - Initializes the rental records form with admin context and loads data
        public RentalRecords(Admin admin)
        {
            InitializeComponent();

            _currentAdmin = admin;
            _context = new CarRentalDbContext();

            LoadRentalRecords();
            InitializeEventHandlers();
        }

        // Button Click Events
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            var dashboardForm = new AdminDashboard(_currentAdmin);
            dashboardForm.FormClosed += (_, __) => this.Close();
            dashboardForm.Show();
            this.Hide();
        }

        private void buttonManageCars_Click(object sender, EventArgs e)
        {
            var manageCarsForm = new ManageCars(_currentAdmin);
            manageCarsForm.FormClosed += (_, __) => this.Close();
            manageCarsForm.Show();
            this.Hide();
        }

        private void buttonManageCustomers_Click(object sender, EventArgs e)
        {
            var manageCustomerForm = new ManageCustomer(_currentAdmin);
            manageCustomerForm.FormClosed += (_, __) => this.Close();
            manageCustomerForm.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Private Helper Methods
        private void InitializeEventHandlers()
        {
            button1.Click += buttonDashboard_Click;
            button2.Click += buttonManageCars_Click;
            button4.Click += buttonManageCustomers_Click;
            button7.Click += buttonLogOut_Click;
        }

        private void LoadRentalRecords()
        {
            // Load rental records with customer and car information using LINQ joins
            var rentalData = _context.Rentals
                .Join(_context.Customers,
                      rental => rental.CustomerId,
                      customer => customer.CustomerId,
                      (rental, customer) => new { rental, customer })
                .Join(_context.Cars,
                      combined => combined.rental.CarId,
                      car => car.CarId,
                      (combined, car) => new
                      {
                          RentalId = combined.rental.RentalId,
                          CustomerName = combined.customer.FirstName + " " + combined.customer.LastName,
                          Car = car.Brand + " " + car.Model,
                          PlateNumber = car.PlateNumber,
                          RentDate = combined.rental.RentDatee,
                          ReturnDate = combined.rental.ReturnDate,
                          ActualReturnDate = combined.rental.ActualReturnDate,
                          InitialCost = combined.rental.InitialCost,
                          LateFee = combined.rental.LateFee,
                          TotalCost = combined.rental.TotalCost,
                          Status = combined.rental.Status,
                          TransactionCode = combined.rental.TransactionCode
                      })
                .ToList();

            dataGridView1.DataSource = rentalData;
        }

        private void RentalRecords_Load(object sender, EventArgs e)
        {

        }
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
    }
}