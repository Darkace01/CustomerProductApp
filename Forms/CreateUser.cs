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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var user = new User
                {
                    FullName = txtFullName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
            };

            db.Users.Add(user);
            db.SaveChanges();
                MessageBox.Show("Success!!!");
                txtFullName.Text = "";
                txtUserName.Text = "";
                txtPassword.Text = "";
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
            ViewUser newMenu = new ViewUser();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
