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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kazDbDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.kazDbDataSet1.Customers);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
