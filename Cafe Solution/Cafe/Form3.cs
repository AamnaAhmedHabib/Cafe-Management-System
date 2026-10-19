using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cafe.CustomErrorMessageBox;

namespace Cafe
{
    public partial class Cashier_SignIn : Form
    {
        public Cashier_SignIn()
        {
            InitializeComponent();
        }

        private void Close_button_label_Click(object sender, EventArgs e)
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

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = @"SELECT UserID FROM Users 
                          WHERE Username = @Username 
                          AND Password = @Password
                          AND Role = 'cashier'
                          AND Status = 'active'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);//Adds a parameter to a SQL command with automatic type detection
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        object result = command.ExecuteScalar(); //Executes a SQL query and returns only the first column of the first row from the result set

                        if (result != null)
                        {
                            // Successfully authenticated
                            int userIdFromDatabase = Convert.ToInt32(result); //Converts a value to a 32-bit integer

                            // Set session variables
                            UserSession.CurrentUserID = userIdFromDatabase;
                            UserSession.Username = username;
                            UserSession.Role = "cashier";

                            // Proceed to cashier view
                            Cashier_view f5 = new Cashier_view();
                            f5.Show();
                            this.Hide();
                        }
                        else
                        {
                            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                            {
                                CustomDialogResult dialogResult = CEMB.show("Invalid credentials or insufficient privileges", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show($"Login error: {ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }

        private void ShowPassword_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.PasswordChar = ShowPassword_CB.Checked ? '\0' : '*';
        }
    }
}
