using CustomerProductApp.Data;
using CustomerProductApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProductApp.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CustomerSubmit_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var customer = new Customer
                {
                    Name = txtCustomerName.Text,
                    PhoneNumber = txtCustomerPhone.Text,
                    Address = txtCustomerEmail.Text,
                    Email = txtCustomerAddress.Text
                };

                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Success!!!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
