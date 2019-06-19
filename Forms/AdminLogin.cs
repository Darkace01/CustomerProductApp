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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void NewUserAdd_Click(object sender, EventArgs e)
        {
            bool isUser = false;
            bool isPass = false;
            string adminUserName = "Admin";
            string adminPassword = "Password";
            if (txtAdminUser.Text == adminUserName)
            {
                isUser = true;
                if (txtAdminPass.Text == adminPassword)
                {
                    isPass = true;
                }
                else
                    isPass = false;
            }
            else
                isUser = false;
            if ((isUser == true) && (isPass == true))
            {
                CreateUser newMenu = new CreateUser();
                this.Hide();
                newMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Admin username: Admin and Password: Password");
            }
        }

        private void AdminBackBtn_Click(object sender, EventArgs e)
        {
            Home newMenu = new Home();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
