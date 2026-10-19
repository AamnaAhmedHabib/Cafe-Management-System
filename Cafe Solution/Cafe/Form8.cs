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
    public partial class Cashier_CRUD : Form
    {
        private DataTable datatable = new DataTable(); // Global Variable to get Users Data

        private DataTable ordersDataTable = new DataTable(); //Global Variable to get Customers Data

        string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

        private System.Windows.Forms.Timer refreshTimer;

        public Cashier_CRUD()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void Cashier_CRUD_Load(object sender, EventArgs e)
        {
            Search_Filter_CB.Items.AddRange(new string[] { "Order ID", "Server ID", "Category", "Payment" });
            Search_Filter_CB.SelectedIndex = 0;

            LoadCustomerData();

            LoadCashierDashboardStats();
        }

        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 300000; // 5 minutes
            refreshTimer.Tick += (s, e) => LoadCashierDashboardStats();
            refreshTimer.Start();
        }

        //To set an active tab when a button is pressed
        public void SetActiveTab(int tabIndex)
        {
            if (tabIndex >= 0 && tabIndex < Cashier_TC.TabCount)
            {
                Cashier_TC.SelectedIndex = tabIndex;
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
            Cashier_view form = new Cashier_view();
            form.Show();
            this.Close();
        }

        //Add button
        private void Add_button_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Show();
            this.Hide();

            LoadCustomerData();
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
                                Data_Customers_DGV.Columns["OrderDate"].DefaultCellStyle.Format = "g";
                            }

                            if (Data_Customers_DGV.Columns["TotalBill"] != null)
                            {
                                Data_Customers_DGV.Columns["TotalBill"].DefaultCellStyle.Format = "C2";
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (ordersDataTable == null || ordersDataTable.Rows.Count == 0)
                return;

            string searchText = SearchBox.Text.Trim();
            string selectedField = Search_Filter_CB.SelectedItem?.ToString() ?? "Order ID";

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

        private void Search_Filter_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBox_TextChanged(sender, e);
        }

        //Cashier Dashboard
        private void LoadCashierDashboardStats()
        {
            try
            {
                int cashierId = UserSession.CurrentUserID;

                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();

                    //Cashier's current day's stats
                    using (SqlCommand cmd = new SqlCommand("GetCashierTodayStats", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CashierID", cashierId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Customers_Served_Label1.Text = reader["CustomersServed"].ToString();
                                Today_Income_Label1.Text = Convert.ToDecimal(reader["DailySales"]).ToString("C2");
                            }
                        }
                    }

                    // Cashier's weekly stats
                    using (SqlCommand cmd = new SqlCommand("GetCashierWeeklyStats", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CashierID", cashierId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Weekly_income_Label1.Text = Convert.ToDecimal(reader["WeeklySales"]).ToString("C2");
                            }
                        }
                    }

                    // Today's total customers
                    using (SqlCommand cmd = new SqlCommand("GetTodaysTotalCustomers", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        No_Of_Customers_Label1.Text = cmd.ExecuteScalar().ToString();
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
