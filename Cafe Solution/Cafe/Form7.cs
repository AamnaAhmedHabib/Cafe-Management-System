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
using static System.Windows.Forms.DataFormats;

namespace Cafe
{
    public partial class Add_Products_Menu : Form
    {
        private DataTable datatable = new DataTable();
        //private List<Panel> allMenuPanels = new List<Panel>();

        public Add_Products_Menu()
        {
            InitializeComponent();
            LoadMenuItems(); //Loading existing menu items on form startup
        }

        //Main Functioning Buttons
        private void Close_button_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_label_button_Click(object sender, EventArgs e)
        {
            Admin_view form = new Admin_view();
            form.Show();
            this.Hide();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            //Open the dialog for adding a new item
            CustomMessageBox form = new CustomMessageBox
            {
                ButtonOwner = null, //No owner button for new items
                Itemid = 0, //0 indicates a new item
                IsUpdate = false //This is an add operation
            };

            DialogResult result = form.ShowDialog();

            //If the user saved the new item
            if (result == DialogResult.OK)
            {
                //Get the newly added item from the database
                string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    //Get the most recently added item
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 ItemID, ItemName, ItemPic, Price FROM MenuItems ORDER BY ItemID DESC", sqlcon))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Image buttonImage = null;
                                if (reader["ItemPic"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["ItemPic"];
                                    buttonImage = GetImageFromBytes(imageData);
                                }
                                decimal price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0;

                                // Add the new item
                                CreateMenuButton(
                                    reader["ItemName"].ToString(),
                                    buttonImage,
                                    (int)reader["ItemID"],
                                    price
                                );

                                // Reorganize to maintain layout
                                ReorganizeMenuPanels(Menu_panel);
                            }
                        }
                    }
                }
            }
        }

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
            
        }

        //Creates a complete menu item panel containing a button, name label, and price label
        private Panel CreateMenuItemPanel(string buttonText, Image buttonImage, int itemId, decimal price = 0)
        {
            //Creating a container panel
            Panel itemPanel = new Panel
            {
                Size = new Size(90, 130),
                BackColor = Color.Transparent,
                Tag = itemId
            };

            //Creating the button
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

            //Setting image if provided
            if (buttonImage != null)
            {
                itemButton.Image = ResizeImage(buttonImage, 60, 60);
                itemButton.Text = "";
            }

            //Creating name label
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

            //Creating price label
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

            //Add controls to panel, this is like creating objects from a class
            itemPanel.Controls.Add(itemButton);
            itemPanel.Controls.Add(nameLabel);
            itemPanel.Controls.Add(priceLabel);

            return itemPanel;
        }

        //Creates and positions a complete menu item in the main panel
        private void CreateMenuButton(string buttonText, Image buttonImage, int itemId, decimal price = 0)
        {
            Panel pb = Menu_panel;

            //Panel dimensions and spacing
            int panelWidth = 90;
            int panelHeight = 130;
            int horizontalSpacing = 15;
            int verticalSpacing = 20;
            int leftMargin = 20;
            int topMargin = 20;

            //Calculating how many panels fit per row
            int panelsPerRow = (pb.Width - leftMargin) / (panelWidth + horizontalSpacing);
            int existingPanels = pb.Controls.OfType<Panel>().Count();

            //Calculate position
            int row = existingPanels / panelsPerRow;
            int col = existingPanels % panelsPerRow;

            //Creating the item panel with button and labels
            Panel itemPanel = CreateMenuItemPanel(buttonText, buttonImage, itemId, price);
            itemPanel.Location = new Point(
                leftMargin + col * (panelWidth + horizontalSpacing),
                topMargin + row * (panelHeight + verticalSpacing)
            );

            //References to the controls inside the panel
            Button itemButton = itemPanel.Controls.OfType<Button>().First();
            Label nameLabel = itemPanel.Controls.OfType<Label>().First();
            Label priceLabel = itemPanel.Controls.OfType<Label>().Last();

            //Click event to open Message Box Form
            itemButton.Click += (s, args) =>
            {
                CustomMessageBox form = new CustomMessageBox
                {
                    ButtonOwner = itemButton,
                    Itemid = (int)itemButton.Tag,
                    IsUpdate = true
                };

                DialogResult result = form.ShowDialog();

                //Update button after the dialog closes
                if (result == DialogResult.OK)
                {
                    //Refreshing the data from the database
                    string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
                    using (SqlConnection sqlcon = new SqlConnection(connstring))
                    {
                        sqlcon.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT ItemName, ItemPic, Price FROM MenuItems WHERE ItemID = @ItemID", sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@ItemID", (int)itemButton.Tag);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Update image if changed
                                    if (reader["ItemPic"] != DBNull.Value)
                                    {
                                        byte[] imageData = (byte[])reader["ItemPic"];
                                        itemButton.Image = ResizeImage(GetImageFromBytes(imageData), 60, 60);
                                        itemButton.Text = "";
                                    }
                                    else
                                    {
                                        itemButton.Image = null;
                                        itemButton.Text = reader["ItemName"].ToString();
                                    }

                                    //Update name label
                                    nameLabel.Text = reader["ItemName"].ToString();

                                    //Update price label
                                    decimal price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0;
                                    priceLabel.Text = $"${price:0.00}";
                                }
                            }
                        }
                    }
                }
            };

            //Right click to remove items
            itemButton.MouseDown += (s, me) =>
            {
                if (me.Button == MouseButtons.Right)
                {
                    using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                    {
                        CustomDialogResult result = CEMB.show("Are you sure you want to \nremove this product?",
                            "Product Removal",
                            CustomErrorMessageBox.MessageBoxButtons.YesNO);

                        if (result == CustomDialogResult.Yes)
                        {
                            try
                            {
                                // Delete from database first
                                DeleteMenuItem((int)itemButton.Tag);

                                // Find and remove the parent panel
                                Panel parentPanel = itemButton.Parent as Panel;
                                if (parentPanel != null)
                                {
                                    pb.Controls.Remove(parentPanel);
                                    parentPanel.Dispose();
                                    ReorganizeMenuPanels(pb);
                                }
                            }
                            catch (Exception ex)
                            {
                                using (CustomErrorMessageBox errorBox = new CustomErrorMessageBox())
                                {
                                    errorBox.show($"Error deleting item: {ex.Message}",
                                        "Error",
                                        CustomErrorMessageBox.MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
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

        //Recalculating positions of all menu items to maintain proper grid layout
        private void ReorganizeMenuPanels(Panel pb)
        {
            const int panelWidth = 90;
            const int panelHeight = 130;
            const int horizontalSpacing = 15;
            const int verticalSpacing = 20;
            const int leftMargin = 20;
            const int topMargin = 20;

            // Getting all existing panels
            var panels = pb.Controls.OfType<Panel>().ToList();

            //How many fit per row based on current container width
            int panelsPerRow = (pb.Width - leftMargin) / (panelWidth + horizontalSpacing);


            //Repositioning each panel in the grid
            for (int i = 0; i < panels.Count; i++)
            {
                //Calculating new grid position
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;

                //Update panel location
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
                return null; //if there is no image retur null this wont give error if you dont insert an image

            try
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    //Create a copy of the image to avoid disposal/deletionxs issues
                    return new Bitmap(Image.FromStream(ms));
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
