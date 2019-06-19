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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kazDbDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.kazDbDataSet2.Users);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu newMenu = new Menu();
            this.Hide();
            newMenu.ShowDialog();
        }
    }
}
