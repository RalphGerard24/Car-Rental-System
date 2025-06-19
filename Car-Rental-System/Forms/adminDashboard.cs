using Car_Rental_System.Models;
using System;
using System.Windows.Forms;

namespace Car_Rental_System.Forms
{
    public partial class adminDashboard : Form
    {
        private Admin _currentAdmin;

        public adminDashboard(Admin admin)
        {
            InitializeComponent();
            _currentAdmin = admin;

        }
    }
}
