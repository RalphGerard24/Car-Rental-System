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
    public partial class CustomerDetails : Form
    {
        private readonly string _CustomerId;

        public CustomerDetails(string CustomerId)
        {
            InitializeComponent();
            _CustomerId = CustomerId;

            // For now, just show the customer ID to verify it's working
            MessageBox.Show($"Customer ID loaded: {_CustomerId}");

            // TODO: Load and populate customer data here
        }
    }

}
