using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cafe.CustomErrorMessageBox;

namespace Cafe
{
    public partial class Admin_CRUD : Form
    {
        private DataTable datatable = new DataTable(); // Global Variable to get Users Data

        private DataTable ordersDataTable = new DataTable(); //Global Variable to get Customers Data

        string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

        private System.Windows.Forms.Timer refreshTimer; //This is for the timer

        public Admin_CRUD()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void Admin_CRUD_Load(object sender, EventArgs e)
        {
            Search_Filter_CB.Items.AddRange(new string[] { "First Name", "Last Name", "Username", "Email", "Phone" });
            Search_Filter_CB.SelectedIndex = 0;

            Filter_CB2.Items.AddRange(new string[] { "Order ID", "Server ID", "Category", "Payment" });
            Filter_CB2.SelectedIndex = 0;

            LoadUserData();// Populates user DataGridView

            LoadCustomerData();// Populates orders DataGridView

            LoadDashboardStats();// Updates dashboard metrics
        }

        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 300000; // 5 minutes
            refreshTimer.Tick += (s, e) => LoadDashboardStats(); // Refresh stats on tick
            refreshTimer.Start();
        }

        // Method to set the active tab
        public void SetActiveTab(int tabIndex)
        {
            if (tabIndex >= 0 && tabIndex < Admin_TC.TabCount)
            {
                Admin_TC.SelectedIndex = tabIndex;
            }
        }

        //Main functioning buttons
        private void Close_button_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_button_label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back_label_button_Click(object sender, EventArgs e)
        {
            Admin_view form = new Admin_view();
            form.Show();
            this.Close();
        }

        //User Data 
        private void LoadUserData()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("GetUserData", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        datatable = new DataTable();
                        datatable.Load(reader);
                    }
                }

                Data_Users_DGV.DataSource = datatable; //Binds to DataGridView
                Data_Users_DGV.AutoResizeColumns(); //Adjusts column widths
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show($"Error loading user data: {ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }

            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (datatable == null || datatable.Rows.Count == 0)
                return;

            string searchText = SearchBox.Text.Trim();
            string selectedField = Search_Filter_CB.SelectedItem?.ToString() ?? "First Name";

            //Maps UI field names to database column names
            string filterField = selectedField switch
            {
                "First Name" => "FirstName",
                "Last Name" => "LastName",
                "Username" => "Username",
                "Email" => "Email",
                "Phone" => "Phone",
                _ => "FirstName"
            };

            try
            {
                DataView dvUsers = datatable.DefaultView;

                if (string.IsNullOrEmpty(searchText))
                {
                    dvUsers.RowFilter = "";
                }
                else
                {
                    // Escape special characters for LIKE clause
                    string safeSearchText = searchText
                        .Replace("[", "[[]")
                        .Replace("%", "[%]")
                        .Replace("_", "[_]");

                    dvUsers.RowFilter = $"{filterField} LIKE '%{safeSearchText}%'";
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CEMB.show($"Error applying filter: {ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }

            }
        }

        private void Search_Filter_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchBox_TextChanged(sender, e);
        }

        private void Add_button_Click_1(object sender, EventArgs e)
        {
            Add_Users form = new Add_Users();
            form.ShowDialog();
            LoadUserData(); //Refreshing the data after adding a new user
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            int selectedRow = Data_Users_DGV.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int UID = Convert.ToInt32(Data_Users_DGV.Rows[selectedRow].Cells["UserID"].Value);

            Add_Users add_Users = new Add_Users();
            add_Users.Userid = UID;
            add_Users.IsUpdate = true;
            add_Users.ShowDialog(); //Shows edit form with user data

            LoadUserData();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (Data_Users_DGV.SelectedRows.Count > 0)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    var result = CEMB.show("Are you sure you want to delete this user?", "Confirm", CustomErrorMessageBox.MessageBoxButtons.YesNO);


                    if (result == CustomDialogResult.Yes)
                    {
                        int userId = Convert.ToInt32(Data_Users_DGV.SelectedRows[0].Cells["UserID"].Value);

                        using (SqlConnection sqlcon = new SqlConnection(connstring))
                        {
                            sqlcon.Open();
                            using (SqlCommand cmd = new SqlCommand("DeleteUser", sqlcon))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        LoadUserData(); // Refresh data after deletion
                    }
                }
            }
            else
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CEMB.show("Please Select a User to delete!", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }

        //Customer Data
        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("GetOrderData", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            ordersDataTable = new DataTable();
                            da.Fill(ordersDataTable);

                            // Bind to DataGridView
                            Data_Customers_DGV.DataSource = ordersDataTable;

                            // Format columns
                            if (Data_Customers_DGV.Columns["OrderDate"] != null)
                            {
                                Data_Customers_DGV.Columns["OrderDate"].DefaultCellStyle.Format = "g"; // General date/time
                            }

                            if (Data_Customers_DGV.Columns["TotalBill"] != null)
                            {
                                Data_Customers_DGV.Columns["TotalBill"].DefaultCellStyle.Format = "C2"; // Currency format
                            }

                            Data_Customers_DGV.AutoResizeColumns();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show($"Error loading order data: {ex.Message}", "Error",
                        CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }

        private void SearchBox2_TextChanged(object sender, EventArgs e)
        {
            if (ordersDataTable == null || ordersDataTable.Rows.Count == 0)
                return;

            string searchText = SearchBox2.Text.Trim();
            string selectedField = Filter_CB2.SelectedItem?.ToString() ?? "Order ID";

            //Maps UI field names to database column names
            string filterField = selectedField switch
            {
                "Order ID" => "OrderID",
                "Server ID" => "ServerID",
                "Category" => "Category",
                "Payment" => "Payment",
                _ => "OrderID"
            };

            try
            {
                DataView dvOrders = ordersDataTable.DefaultView;

                if (string.IsNullOrEmpty(searchText))
                {
                    dvOrders.RowFilter = "";
                }
                else
                {
                    // Handle different data types appropriately
                    if (filterField == "OrderID" || filterField == "ServerID")
                    {
                        // Numeric search
                        if (int.TryParse(searchText, out int numericValue))
                        {
                            dvOrders.RowFilter = $"{filterField} = {numericValue}";
                        }
                        else
                        {
                            dvOrders.RowFilter = $"{filterField} = -1"; // Show nothing if invalid number
                        }
                    }
                    else
                    {
                        // Text search
                        string safeSearchText = searchText
                            .Replace("[", "[[]")
                            .Replace("%", "[%]")
                            .Replace("_", "[_]");

                        dvOrders.RowFilter = $"{filterField} LIKE '%{safeSearchText}%'";
                    }
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CEMB.show($"Error applying filter: {ex.Message}", "Error",
                        CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }

        private void Filter_CB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBox2_TextChanged(sender, e);
        }

        //Dashboard
        private void LoadDashboardStats()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();

                    //Total Active Users
                    using (SqlCommand cmd = new SqlCommand("GetActiveUsersCount", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        Total_Users_Number_label.Text = cmd.ExecuteScalar().ToString();
                    }

                    //Total Today's Customers
                    using (SqlCommand cmd = new SqlCommand("GetTodaysCustomerCount", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        Total_Customer_Number_label.Text = cmd.ExecuteScalar().ToString();
                    }

                    //Today's Income
                    using (SqlCommand cmd = new SqlCommand("GetTodaysIncome", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        decimal income = Convert.ToDecimal(cmd.ExecuteScalar());
                        Todays_Income_Number_label.Text = income.ToString("C2");
                    }

                    //Weekly Income
                    using (SqlCommand cmd = new SqlCommand("GetWeeklyIncome", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        decimal income = Convert.ToDecimal(cmd.ExecuteScalar());
                        Weekly_Income_Number_label.Text = income.ToString("C2");
                    }
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CEMB.show($"Error loading dashboard stats: {ex.Message}", "Error",
                        CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }
      
    }
}
