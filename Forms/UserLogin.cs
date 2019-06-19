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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            AdminLogin newMenu = new AdminLogin();
            this.Hide();
            newMenu.ShowDialog();
        }

        private void UserLoginBtn_Click(object sender, EventArgs e)
        {
            string loginUserName = txtUserName.Text;
            var isUser = false;

            using (var db = new AppDbContext())
            {
                foreach (var userName in db.Users)
                {
                    foreach (var item in db.Users)
                    {
                        try
                        {
                            if (item.UserName.Equals(loginUserName))
                            {
                                isUser = true;
                            }
                        }catch
                        {

                        }
                        }
                    if (isUser == true)
                    {
                        Menu newMenu = new Menu();
                        this.Hide();
                        newMenu.ShowDialog();
                    }
                    else
                    {
                        labelAlert.Text = "Invalid Username or password";
                    }
                }
            }
        }
    }
}
