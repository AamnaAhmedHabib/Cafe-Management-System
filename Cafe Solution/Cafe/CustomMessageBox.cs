using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cafe.CustomErrorMessageBox;

namespace Cafe
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            ItemID_Label.Text = "[Not Set]"; // Initial value
        }

        public Image ItemImage
        {
            get; private set;
        }

        public string ItemName
        {
            get; private set;
        }

        public Button ButtonOwner
        {
            get; set;
        }

        public int Itemid
        {
            get; set;
        }

        public bool IsUpdate
        {
            get; set;
        }

        string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

        private int _Itemid = 0;
        private bool _isUpdate = false;

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                // Show the User ID for existing users
                ItemID_Label.Text = $"{this.Itemid}";
                Add_Item_label.Text = "Update Item";

                DataTable IRecord = LoadItemDataUpdate();
                if (IRecord.Rows.Count > 0)
                {
                    DataRow row = IRecord.Rows[0];
                    Item_Name_TB.Text = row["ItemName"].ToString();
                    Price_TB.Text = row["Price"].ToString();
                    Food_category_CB.Text = row["Category"].ToString();

                    if (row["ItemPic"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])row["ItemPic"];
                        Food_Image.Image = getImage(imgBytes);
                        Food_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        Food_Image.Image = null;
                    }
                }
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(ItemID), 0) + 1 FROM MenuItems", sqlcon))
                    {
                        object result = cmd.ExecuteScalar();
                        int nextID = result != DBNull.Value ? Convert.ToInt32(result) : 1;
                        ItemID_Label.Text = $"{nextID}";
                        this.Itemid = nextID; // Make sure to set the Itemid property
                    }
                }
            }
        }

        public void UpdateRecord()
        {
            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("AddItems", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemID", this.Itemid);
                    cmd.Parameters.AddWithValue("@ItemName", Item_Name_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Price", Price_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Category", Food_category_CB.SelectedItem.ToString());

                    byte[] photo = getPhoto();
                    cmd.Parameters.AddWithValue("@ItemPic", photo != null ? (object)photo : DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                        {
                            CustomDialogResult result = CEMB.show("Item Updated successfully!", "Success", CustomErrorMessageBox.MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                        {
                            CustomDialogResult result = CEMB.show("Item not Updated!", "Warning", CustomErrorMessageBox.MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        public void InsertRecord()
        {
            try
            {
                // Validate combo box selections
                if (Food_category_CB.SelectedItem == null)
                {
                    using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                    {
                        CustomDialogResult result = CEMB.show("Please select Food Category!", "Validation Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                    }

                    return;
                }

                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("AddItems", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ItemID", this.Itemid);
                        cmd.Parameters.AddWithValue("@ItemName", Item_Name_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Price", Price_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Category", Food_category_CB.SelectedItem.ToString());

                        byte[] photo = getPhoto();
                        cmd.Parameters.AddWithValue("@ItemPic", photo != null ? (object)photo : DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                            {
                                CustomDialogResult result = CEMB.show("Item added successfully!", "Success", CustomErrorMessageBox.MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                            {
                                CustomDialogResult result = CEMB.show("Item not added!", "Warning", CustomErrorMessageBox.MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CEMB.show($"Database error occurred:\n{ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CEMB.show($"An unexpected error occurred:\n{ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }
            }
        }

        private byte[] getPhoto()
        {
            // Return null if no image is selected
            if (Food_Image.Image == null)
                return null;

            using (MemoryStream stream = new MemoryStream())
            {
                // Use PNG format as default if RawFormat isn't available
                ImageFormat format = Food_Image.Image.RawFormat;
                if (format == null)
                    format = ImageFormat.Png;

                Food_Image.Image.Save(stream, format);
                return stream.ToArray(); // Use ToArray() instead of GetBuffer()
            }

        }

        private Image? getImage(byte[] img)
        {
            if (img == null || img.Length == 0)
                return null; // or return a default image

            try
            {
                using (MemoryStream ms = new MemoryStream(img))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null; // or return a default image
            }
        }

        private DataTable LoadItemDataUpdate()
        {
            DataTable ItemRecord = new DataTable();
            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateItem", sqlcon))
                {
                    sqlcon.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemID", this.Itemid);
                    SqlDataReader reader = cmd.ExecuteReader();
                    ItemRecord.Load(reader);
                }
            }
            return ItemRecord;
        }

        private void Username_Label_Click(object sender, EventArgs e)
        {

        }

        private void Upload_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // Load image directly without tempImage
                        Food_Image.Image?.Dispose();
                        Food_Image.Image = Image.FromFile(dialog.FileName);
                        Food_Image.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                {
                    CustomDialogResult result = CEMB.show($"Error loading image: {ex.Message}", "Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                }

            }
        }

        private void Close_button_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
            {
                CustomDialogResult result = CEMB.show("Are you sure you want to clear all fields?", "Confirm Clear", CustomErrorMessageBox.MessageBoxButtons.YesNO);

                if (result == CustomDialogResult.Yes)
                {
                    //Clearing all textboxes
                    Item_Name_TB.Clear();
                    Price_TB.Clear();

                    //Reseting combo boxes to default 
                    Food_category_CB.SelectedIndex = -1;

                    //Clearing the food picture
                    Food_Image.Image?.Dispose();
                    Food_Image.Image = null;
                }
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                UpdateRecord();
            }
            else
            {
                InsertRecord();
            }

            // Set the public properties before closing
            if (Food_Image.Image != null)
            {
                // Create a resized copy of the image for the button
                ItemImage = ResizeImage(Food_Image.Image, 64, 64);
                ItemName = Item_Name_TB.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Helper method to resize images for buttons
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }


    }
}
