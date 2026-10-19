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
    public partial class Order : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

        private Dictionary<int, int> itemCounters = new Dictionary<int, int>(); //tracks how many of each menu item a customer has selected

        private int currentOrderId;
        private int currentCustomerId;
        private int currentServerId = UserSession.CurrentUserID; //Gets logged-in cashier's ID
        private decimal totalBill = 0;
        private int totalItems = 0;
        private int dailyCustomerNumber;
        private int dailyOrderNumber;


        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // Set server ID from session
            currentServerId = UserSession.CurrentUserID;
            ServerID_Label.Text = currentServerId.ToString();

            // Initialize IDs
            currentCustomerId = 0;
            currentOrderId = 0;
            dailyCustomerNumber = 0;
            dailyOrderNumber = 0;

            // Display initial values
            UpdateDisplayedIDs();

            // Load menu items
            LoadMenuItems();

            // Initialize totals
            UpdateTotals();
        }

        private void UpdateDisplayedIDs()
        {
            CustomerID_Label.Text = currentCustomerId > 0 ? currentCustomerId.ToString() : "New";
            OrderID_Label.Text = currentOrderId > 0 ? currentOrderId.ToString() : "New";
            //DailyCustomerNumber_Label.Text = dailyCustomerNumber > 0 ? dailyCustomerNumber.ToString() : "New";
            //DailyOrderNumber_Label.Text = dailyOrderNumber > 0 ? dailyOrderNumber.ToString() : "New";
        }


        // 1. Copy this method from Form7 to load items from the database
        private void LoadMenuItems()
        {
            string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ItemID, ItemName, ItemPic, Price FROM MenuItems", sqlcon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Get image data
                            Image buttonImage = null;
                            if (reader["ItemPic"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["ItemPic"];
                                buttonImage = GetImageFromBytes(imageData);
                            }

                            // Get price
                            decimal price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0;

                            // Create button for each item
                            CreateMenuButton(
                                reader["ItemName"].ToString(),
                                buttonImage,
                                (int)reader["ItemID"],
                                price
                            );
                        }
                    }
                }
            }
            // Removed the "+" button creation here
        }

        private Panel CreateMenuItemPanel(string buttonText, Image buttonImage, int itemId, decimal price = 0)
        {
            // Create a container panel
            Panel itemPanel = new Panel
            {
                Size = new Size(90, 130),
                BackColor = Color.Transparent,
                Tag = itemId
            };

            // Create the button
            Button itemButton = new Button
            {
                Text = buttonText,
                Font = new Font("Pixelify Sans", 8f, FontStyle.Bold),
                ForeColor = Color.WhiteSmoke,
                BackColor = Color.FromArgb(51, 35, 31),
                FlatStyle = FlatStyle.Popup,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(70, 70),
                Location = new Point(10, 0),
                TextAlign = ContentAlignment.MiddleCenter,
                ImageAlign = ContentAlignment.MiddleCenter,
                Tag = itemId
            };

            // Set image if provided
            if (buttonImage != null)
            {
                itemButton.Image = ResizeImage(buttonImage, 60, 60);
                itemButton.Text = "";
            }

            // Create name label
            Label nameLabel = new Label
            {
                Text = buttonText,
                Font = new Font("Pixelify Sans", 8f, FontStyle.Bold),
                ForeColor = Color.FromArgb(181, 148, 16),
                BackColor = Color.Transparent,
                Size = new Size(70, 20),
                Location = new Point(10, 72),
                TextAlign = ContentAlignment.TopCenter
            };

            // Create price label
            Label priceLabel = new Label
            {
                Text = $"${price:0.00}",
                Font = new Font("Pixelify Sans", 8f, FontStyle.Regular),
                ForeColor = Color.FromArgb(181, 148, 16),
                BackColor = Color.Transparent,
                Size = new Size(70, 15),
                Location = new Point(10, 92),
                TextAlign = ContentAlignment.TopCenter
            };

            // Add controls to panel
            itemPanel.Controls.Add(itemButton);
            itemPanel.Controls.Add(nameLabel);
            itemPanel.Controls.Add(priceLabel);

            return itemPanel;
        }

        private void CreateMenuButton(string buttonText, Image buttonImage, int itemId, decimal price = 0)
        {
            Panel pb = Menu_panel;

            // Panel dimensions and spacing
            int panelWidth = 90;
            int panelHeight = 130;
            int horizontalSpacing = 15;
            int verticalSpacing = 20;
            int leftMargin = 20;
            int topMargin = 20;

            // Calculate how many panels fit per row
            int panelsPerRow = (pb.Width - leftMargin) / (panelWidth + horizontalSpacing);
            int existingPanels = pb.Controls.OfType<Panel>().Count();

            // Calculate position
            int row = existingPanels / panelsPerRow;
            int col = existingPanels % panelsPerRow;

            // Create the item panel with button and labels
            Panel itemPanel = CreateMenuItemPanel(buttonText, buttonImage, itemId, price);
            itemPanel.Location = new Point(
                leftMargin + col * (panelWidth + horizontalSpacing),
                topMargin + row * (panelHeight + verticalSpacing)
            );

            // Get references to the controls inside the panel
            Button itemButton = itemPanel.Controls.OfType<Button>().First();
            Label nameLabel = itemPanel.Controls.OfType<Label>().First();
            Label priceLabel = itemPanel.Controls.OfType<Label>().Last();

            // Add counter label
            Label counterLabel = new Label
            {
                Text = "0",
                Font = new Font("Pixelify Sans", 10f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(181, 148, 16),
                Size = new Size(25, 25),
                Location = new Point(45, 45),
                TextAlign = ContentAlignment.MiddleCenter,
                Tag = itemId
            };
            itemPanel.Controls.Add(counterLabel);
            counterLabel.BringToFront();

            // Initialize counter for this item
            itemCounters[itemId] = 0;

            // Left click to increment counter
            itemButton.Click += (s, args) =>
            {
                itemCounters[itemId]++;
                counterLabel.Text = itemCounters[itemId].ToString();
                UpdateTotals();
            };

            // Right click to decrement counter
            itemButton.MouseDown += (s, me) =>
            {
                if (me.Button == MouseButtons.Right && itemCounters[itemId] > 0)
                {
                    itemCounters[itemId]--;
                    counterLabel.Text = itemCounters[itemId].ToString();
                    UpdateTotals();
                }
            };

            pb.Controls.Add(itemPanel);
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        //This helps to reorganize buttons after deleting them
        private void ReorganizeButtons(Panel pb)
        {
            const int buttonWidth = 70;
            const int buttonHeight = 70;
            const int horizontalSpacing = 15;
            const int verticalSpacing = 50;
            const int leftMargin = 20;
            const int topMargin = 20;

            var buttons = pb.Controls.OfType<Button>().ToList();
            int buttonsPerRow = (pb.Width - leftMargin) / (buttonWidth + horizontalSpacing);

            for (int i = 0; i < buttons.Count; i++)
            {
                int row = i / buttonsPerRow;
                int col = i % buttonsPerRow;

                buttons[i].Location = new Point(
                    leftMargin + col * (buttonWidth + horizontalSpacing),
                    topMargin + row * (buttonHeight + verticalSpacing)
                );
                buttons[i].Tag = $"btn_{i + 1}";
            }
        }

        private void ReorganizeMenuPanels(Panel pb)
        {
            const int panelWidth = 90;
            const int panelHeight = 130;
            const int horizontalSpacing = 15;
            const int verticalSpacing = 20;
            const int leftMargin = 20;
            const int topMargin = 20;

            var panels = pb.Controls.OfType<Panel>().ToList();
            int panelsPerRow = (pb.Width - leftMargin) / (panelWidth + horizontalSpacing);

            for (int i = 0; i < panels.Count; i++)
            {
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;

                panels[i].Location = new Point(
                    leftMargin + col * (panelWidth + horizontalSpacing),
                    topMargin + row * (panelHeight + verticalSpacing)
                );
                panels[i].Tag = $"panel_{i + 1}";
            }
        }

        private void DeleteMenuItem(int itemId)
        {
            string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM MenuItems WHERE ItemID = @ItemID", sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Image GetImageFromBytes(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Create a copy of the image to avoid disposal issues
                    return new Bitmap(Image.FromStream(ms));
                }
            }
            catch
            {
                return null;
            }
        }

        private int GetNewCustomerId()
        {
            string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                using (SqlCommand command = new SqlCommand("AddCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter customerIdParam = new SqlParameter("@CustomerID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(customerIdParam);

                    SqlParameter dailyNumberParam = new SqlParameter("@DailyCustomerNumber", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(dailyNumberParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    dailyCustomerNumber = Convert.ToInt32(dailyNumberParam.Value);
                    return Convert.ToInt32(customerIdParam.Value);
                }
            }
        }

        private void UpdateTotals()
        {
            totalItems = itemCounters.Sum(x => x.Value);
            TotalItems_Label.Text = totalItems.ToString();

            // Calculate total bill by summing (price * quantity) for all items
            totalBill = 0;
            foreach (var item in itemCounters)
            {
                if (item.Value > 0)
                {
                    decimal price = GetItemPrice(item.Key);
                    totalBill += price * item.Value;
                }
            }
            TotalBill_Label.Text = $"${totalBill:0.00}";
        }

        private decimal GetItemPrice(int itemId)
        {
            string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Price FROM MenuItems WHERE ItemID = @ItemID", connection))
                {
                    command.Parameters.AddWithValue("@ItemID", itemId);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }


        private void Close_button_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_label_button_Click(object sender, EventArgs e)
        {
            Cashier_CRUD form = new Cashier_CRUD();
            form.SetActiveTab(1);
            form.Show();
            this.Hide();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            // Validate selections
            if (Order_category_CB.SelectedItem == null)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show("Please select a category", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
                return;
            }

            if (Payment_CB.SelectedItem == null)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show("Please select Payment Method", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
                return;
            }

            if (totalItems == 0)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show("Please add atleast 1 item to the order!", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
                return;
            }

            try
            {
                string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    connection.Open();

                    // Get customer ID if we don't have one
                    if (currentCustomerId == 0)
                    {
                        currentCustomerId = GetNewCustomerId();
                    }

                    // Save the order
                    using (SqlCommand command = new SqlCommand("AddOrder", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@CustomerID", currentCustomerId);
                        command.Parameters.AddWithValue("@ServerID", currentServerId);
                        command.Parameters.AddWithValue("@Category", Order_category_CB.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Payment", Payment_CB.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@TotalItems", totalItems);
                        command.Parameters.AddWithValue("@TotalBill", totalBill);

                        SqlParameter orderIdParam = new SqlParameter("@OrderID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(orderIdParam);

                        SqlParameter dailyOrderNumParam = new SqlParameter("@DailyOrderNumber", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(dailyOrderNumParam);

                        command.ExecuteNonQuery();

                        currentOrderId = Convert.ToInt32(orderIdParam.Value);
                        dailyOrderNumber = Convert.ToInt32(dailyOrderNumParam.Value);

                        // Update displayed IDs
                        UpdateDisplayedIDs();

                        // Show success message
                        using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                        {
                            CustomDialogResult result = CEMB.show($"Order #{dailyOrderNumber} saved successfully! (ID: {currentOrderId})", 
                                "Success", 
                                CustomErrorMessageBox.MessageBoxButtons.OK);
                        }

                        // Reset for new order (but keep the same server)
                        ResetOrder();
                    }
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show($"Error saving order: {ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }

            //Updating Admin's Dashboard
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateDailySummary", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                //This will log the error but won't prevent order to be completed
                Console.WriteLine($"Error updating daily summary: {ex.Message}");
            }

            //Updating Cashier's Dasboard
            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateCashierPerformance", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CashierID", currentServerId);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error but don't prevent order completion
                Console.WriteLine($"Error updating cashier performance: {ex.Message}");
            }
        }
        
        

        private void ResetOrder()
        {
            foreach (var key in itemCounters.Keys.ToList())
            {
                itemCounters[key] = 0;
            }

            foreach (Panel panel in Menu_panel.Controls.OfType<Panel>())
            {
                Label counterLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.BackColor == Color.FromArgb(181, 148, 16));
                if (counterLabel != null) counterLabel.Text = "0";
            }

            // Reset IDs (but keep server ID)
            currentCustomerId = 0;
            currentOrderId = 0;
            dailyCustomerNumber = 0;
            dailyOrderNumber = 0;

            // Update displayed IDs
            UpdateDisplayedIDs();

            // Reset other UI elements
            Order_category_CB.SelectedIndex = -1;
            Payment_CB.SelectedIndex = -1;
            totalBill = 0;
            totalItems = 0;
            UpdateTotals();
        }


    }
}
