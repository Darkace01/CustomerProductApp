using CustomerProductApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProductApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AdminLogin newMenu = new AdminLogin();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void BtnCrtUser_Click(object sender, EventArgs e)
        {
            CreateUser newMenu = new CreateUser();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void BtnUserLog_Click(object sender, EventArgs e)
        {
            UserLogin newMenu = new UserLogin();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
