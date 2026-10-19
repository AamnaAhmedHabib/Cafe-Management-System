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
    public partial class Add_Users : Form
    {
        public Add_Users()
        {
            InitializeComponent();
            UserID_Label.Text = "[Not Set]"; // Initial value
        }

        string connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

        private int _Userid = 0;
        private bool _isUpdate = false;

        private void Add_Users_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                // Show the User ID for existing users
                UserID_Label.Text = $"{this.Userid}";
                Add_User_label.Text = "Update User";

                DataTable URecord = LoadDataUpdate();
                if (URecord.Rows.Count > 0)
                {
                    DataRow row = URecord.Rows[0];
                    First_Name_TB.Text = row["FirstName"].ToString();
                    Last_Name_TB.Text = row["LastName"].ToString();
                    Email_TB.Text = row["Email"].ToString();
                    Phone_TB.Text = row["Phone"].ToString();
                    Username_TB.Text = row["Username"].ToString();
                    Password_TB.Text = row["Password"].ToString();
                    Salary_TB.Text = row["Salary"].ToString();
                    Role_CB.Text = row["Role"].ToString();
                    Status_CB.Text = row["Status"].ToString();

                    if (row["ProfilePic"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])row["ProfilePic"];
                        User_Image.Image = getImage(imgBytes);
                        User_Image.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        User_Image.Image = null;
                    }
                }
            }
            else
            {
                // For new users - get next available ID
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();

                    // First check if table is empty
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users", sqlcon))
                    {
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount == 0)
                        {
                            UserID_Label.Text = "1";
                        }
                        else
                        {
                            // Get the maximum existing ID and add 1
                            using (SqlCommand maxCmd = new SqlCommand("SELECT ISNULL(MAX(UserID), 0) + 1 FROM Users", sqlcon))
                            {
                                UserID_Label.Text = maxCmd.ExecuteScalar().ToString();
                            }
                        }
                    }
                }
            }
        }
        

        public int Userid
        {
            get; set;   //This is to put the current User ID 
        }

        public bool IsUpdate
        {
            get; set;    //update flag
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
                        User_Image.Image?.Dispose();
                        User_Image.Image = Image.FromFile(dialog.FileName);
                        User_Image.SizeMode = PictureBoxSizeMode.Zoom;
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
        }

        public void UpdateRecord()
        {
            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("AddUsers", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", this.Userid);
                    cmd.Parameters.AddWithValue("@FirstName", First_Name_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@LastName", Last_Name_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Email", Email_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Phone", Phone_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Username", Username_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Password", Password_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Salary", Salary_TB.Text.ToString());
                    cmd.Parameters.AddWithValue("@Role", Role_CB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Status", Status_CB.SelectedItem.ToString());

                    byte[] photo = getPhoto();
                    cmd.Parameters.AddWithValue("@ProfilePic", photo != null ? (object)photo : DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                        {
                            CustomDialogResult result = CEMB.show("User Updated successfully!", "Success", CustomErrorMessageBox.MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                        {
                            CustomDialogResult result = CEMB.show("User not Updated!", "Warning", CustomErrorMessageBox.MessageBoxButtons.OK);
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
                if (Role_CB.SelectedItem == null || Status_CB.SelectedItem == null)
                {
                    using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                    {
                        CustomDialogResult result = CEMB.show("Please select both Role and Status!", "Validation Error", CustomErrorMessageBox.MessageBoxButtons.OK);
                    }

                    return;
                }

                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("AddUsers", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", First_Name_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@LastName", Last_Name_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Email", Email_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Phone", Phone_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Username", Username_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Password", Password_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Salary", Salary_TB.Text.ToString());
                        cmd.Parameters.AddWithValue("@Role", Role_CB.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Status", Status_CB.SelectedItem.ToString());

                        byte[] photo = getPhoto();
                        cmd.Parameters.AddWithValue("@ProfilePic", photo != null ? (object)photo : DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                            {
                                CustomDialogResult result = CEMB.show("User added successfully!", "Success", CustomErrorMessageBox.MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
                            {
                                CustomDialogResult result = CEMB.show("User not added!", "Warning", CustomErrorMessageBox.MessageBoxButtons.OK);
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
            if (User_Image.Image == null)
                return null;

            using (MemoryStream stream = new MemoryStream())
            {
                // Use PNG format as default if RawFormat isn't available
                ImageFormat format = User_Image.Image.RawFormat;
                if (format == null)
                    format = ImageFormat.Png;

                User_Image.Image.Save(stream, format);
                return stream.ToArray(); 
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

        private DataTable LoadDataUpdate()
        {
            DataTable UserRecord = new DataTable();
            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateUser", sqlcon))
                {
                    sqlcon.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", this.Userid);
                    SqlDataReader reader = cmd.ExecuteReader();
                    UserRecord.Load(reader);
                }
            }
            return UserRecord;
        }

        private void Cancel_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            using (CustomErrorMessageBox CEMB = new CustomErrorMessageBox())
            {
                CustomDialogResult result = CEMB.show("Are you sure you want to clear all fields?", "Confirm Clear",CustomErrorMessageBox.MessageBoxButtons.YesNO);
                   
                  if (result == CustomDialogResult.Yes)
                  {
                    // Clearing all text fields
                    First_Name_TB.Clear();
                    Last_Name_TB.Clear();
                    Email_TB.Clear();
                    Phone_TB.Clear();
                    Username_TB.Clear();
                    Password_TB.Clear();
                    Salary_TB.Clear();

                    // Reseting combo boxes
                    Role_CB.SelectedIndex = -1;  // Or set to default value
                    Status_CB.SelectedIndex = -1; // Or set to default value

                    // Clearing the profile picture
                    User_Image.Image?.Dispose();
                    User_Image.Image = null;
                  }
            }
        }
    }
}
