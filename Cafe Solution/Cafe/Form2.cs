using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cafe.CustomErrorMessageBox;

namespace Cafe
{
    public partial class Admin_SignIn : Form
    {
        public Admin_SignIn()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string username = Username_TB.Text.Trim();
            string password = Password_TB.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show("Please enter both username and password", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
                return;
            }

            //AuthenticationHelperClass is made separately
            var (isValid, role) = AuthenticationHelperClass.ValidateUser(username, password, "admin");

            if (isValid)
            {
                Admin_view f4 = new Admin_view();
                f4.Show();
                this.Hide();
            }
            else
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show("Invalid credentials or insufficient privileges", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }

        private void ShowPassword_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.PasswordChar = ShowPassword_CB.Checked ? '\0' : '*';
        }


    }
}
