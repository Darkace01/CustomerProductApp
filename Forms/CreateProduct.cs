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
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int Quantity;
            decimal unitPrice;
            int tax;
            decimal totalAmount;
            if (!int.TryParse(txtQuantity.Text, out Quantity))
            {
                MessageBox.Show("The Quantity is not in correct format");
                return;
            }
            if (!decimal.TryParse(txtQuantity.Text, out unitPrice))
            {
                MessageBox.Show("The unit price is not in correct format");
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out tax))
            {
                MessageBox.Show("The Tax is not in correct format");
                return;
            }
            if (!decimal.TryParse(txtQuantity.Text, out totalAmount))
            {
                MessageBox.Show("The Quantity is not in correct format");
                return;
            }
            using (var db = new AppDbContext())
            {
                var product = new Product
                {
                    ItemName = txtItemName.Text,
                    Quantity = Quantity,
                    UnitPrice = unitPrice,
                    Tax = tax,
                    TotalAmount = totalAmount
                };

                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Success!!!");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ViewProduct newMenu = new ViewProduct();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
