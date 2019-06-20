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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewCustomer newMenu = new ViewCustomer();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddCustomer newMenu = new AddCustomer();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateProduct newMenu = new CreateProduct();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ViewProduct newMenu = new ViewProduct();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Home newMenu = new Home();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
