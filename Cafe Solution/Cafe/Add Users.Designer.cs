namespace Cafe
{
    partial class Add_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Users));
            Upload_button = new Button();
            User_Image = new PictureBox();
            Status_CB = new ComboBox();
            Role_CB = new ComboBox();
            Password_TB = new TextBox();
            Username_TB = new TextBox();
            Status_Label = new Label();
            Role_Label = new Label();
            Password_Label = new Label();
            Username_Label = new Label();
            pictureBox1 = new PictureBox();
            Add_User_label = new Label();
            Close_button_label = new Label();
            Last_Name_TB = new TextBox();
            First_Name_TB = new TextBox();
            Phone_label = new Label();
            Email_label = new Label();
            Last_Name_label = new Label();
            First_Name_label = new Label();
            Phone_TB = new TextBox();
            Email_TB = new TextBox();
            Save_button = new Button();
            Cancel_button = new Button();
            Salary_TB = new TextBox();
            Salary_Label = new Label();
            User_ID_Label = new Label();
            User_ID_L = new Label();
            UserID_Label = new Label();
            Clear_button = new Button();
            ((System.ComponentModel.ISupportInitialize)User_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Upload_button
            // 
            Upload_button.BackColor = Color.FromArgb(111, 76, 68);
            Upload_button.Cursor = Cursors.PanNW;
            Upload_button.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Upload_button.ForeColor = Color.WhiteSmoke;
            Upload_button.Location = new Point(535, 235);
            Upload_button.Name = "Upload_button";
            Upload_button.Size = new Size(31, 144);
            Upload_button.TabIndex = 40;
            Upload_button.Text = "UPLOAD";
            Upload_button.UseVisualStyleBackColor = false;
            Upload_button.Click += Upload_button_Click;
            // 
            // User_Image
            // 
            User_Image.BackgroundImageLayout = ImageLayout.Stretch;
            User_Image.BorderStyle = BorderStyle.FixedSingle;
            User_Image.Location = new Point(578, 235);
            User_Image.Name = "User_Image";
            User_Image.Size = new Size(156, 144);
            User_Image.TabIndex = 39;
            User_Image.TabStop = false;
            // 
            // Status_CB
            // 
            Status_CB.BackColor = Color.FromArgb(111, 76, 68);
            Status_CB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Status_CB.ForeColor = Color.WhiteSmoke;
            Status_CB.FormattingEnabled = true;
            Status_CB.Items.AddRange(new object[] { "Active", "Inactive", "Waiting Approval" });
            Status_CB.Location = new Point(563, 177);
            Status_CB.Name = "Status_CB";
            Status_CB.Size = new Size(202, 31);
            Status_CB.TabIndex = 38;
            // 
            // Role_CB
            // 
            Role_CB.BackColor = Color.FromArgb(111, 76, 68);
            Role_CB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role_CB.ForeColor = Color.WhiteSmoke;
            Role_CB.FormattingEnabled = true;
            Role_CB.Items.AddRange(new object[] { "Admin", "Cashier" });
            Role_CB.Location = new Point(563, 121);
            Role_CB.Name = "Role_CB";
            Role_CB.Size = new Size(202, 31);
            Role_CB.TabIndex = 37;
            // 
            // Password_TB
            // 
            Password_TB.BackColor = Color.FromArgb(111, 76, 68);
            Password_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_TB.ForeColor = Color.WhiteSmoke;
            Password_TB.Location = new Point(150, 405);
            Password_TB.Name = "Password_TB";
            Password_TB.Size = new Size(202, 30);
            Password_TB.TabIndex = 36;
            // 
            // Username_TB
            // 
            Username_TB.BackColor = Color.FromArgb(111, 76, 68);
            Username_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_TB.ForeColor = Color.WhiteSmoke;
            Username_TB.Location = new Point(150, 348);
            Username_TB.Name = "Username_TB";
            Username_TB.Size = new Size(202, 30);
            Username_TB.TabIndex = 35;
            // 
            // Status_Label
            // 
            Status_Label.AutoSize = true;
            Status_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status_Label.ForeColor = Color.WhiteSmoke;
            Status_Label.Location = new Point(451, 180);
            Status_Label.Name = "Status_Label";
            Status_Label.Size = new Size(83, 23);
            Status_Label.TabIndex = 34;
            Status_Label.Text = "Status:";
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Role_Label.ForeColor = Color.WhiteSmoke;
            Role_Label.Location = new Point(451, 123);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(53, 23);
            Role_Label.TabIndex = 33;
            Role_Label.Text = "Role:";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_Label.ForeColor = Color.WhiteSmoke;
            Password_Label.Location = new Point(26, 412);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(105, 23);
            Password_Label.TabIndex = 32;
            Password_Label.Text = "Password:";
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_Label.ForeColor = Color.WhiteSmoke;
            Username_Label.Location = new Point(26, 355);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(106, 23);
            Username_Label.TabIndex = 31;
            Username_Label.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // Add_User_label
            // 
            Add_User_label.AutoSize = true;
            Add_User_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_User_label.ForeColor = Color.White;
            Add_User_label.Location = new Point(48, 18);
            Add_User_label.Name = "Add_User_label";
            Add_User_label.Size = new Size(82, 20);
            Add_User_label.TabIndex = 43;
            Add_User_label.Text = "Add User";
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(747, 13);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 41;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Last_Name_TB
            // 
            Last_Name_TB.BackColor = Color.FromArgb(111, 76, 68);
            Last_Name_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Last_Name_TB.ForeColor = Color.WhiteSmoke;
            Last_Name_TB.Location = new Point(150, 182);
            Last_Name_TB.Name = "Last_Name_TB";
            Last_Name_TB.Size = new Size(202, 30);
            Last_Name_TB.TabIndex = 50;
            // 
            // First_Name_TB
            // 
            First_Name_TB.BackColor = Color.FromArgb(111, 76, 68);
            First_Name_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            First_Name_TB.ForeColor = Color.WhiteSmoke;
            First_Name_TB.Location = new Point(150, 125);
            First_Name_TB.Name = "First_Name_TB";
            First_Name_TB.Size = new Size(202, 30);
            First_Name_TB.TabIndex = 49;
            // 
            // Phone_label
            // 
            Phone_label.AutoSize = true;
            Phone_label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Phone_label.ForeColor = Color.WhiteSmoke;
            Phone_label.Location = new Point(26, 298);
            Phone_label.Name = "Phone_label";
            Phone_label.Size = new Size(100, 23);
            Phone_label.TabIndex = 48;
            Phone_label.Text = "Phone No.:";
            // 
            // Email_label
            // 
            Email_label.AutoSize = true;
            Email_label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email_label.ForeColor = Color.WhiteSmoke;
            Email_label.Location = new Point(26, 241);
            Email_label.Name = "Email_label";
            Email_label.Size = new Size(63, 23);
            Email_label.TabIndex = 47;
            Email_label.Text = "Email:";
            // 
            // Last_Name_label
            // 
            Last_Name_label.AutoSize = true;
            Last_Name_label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Last_Name_label.ForeColor = Color.WhiteSmoke;
            Last_Name_label.Location = new Point(26, 184);
            Last_Name_label.Name = "Last_Name_label";
            Last_Name_label.Size = new Size(114, 23);
            Last_Name_label.TabIndex = 46;
            Last_Name_label.Text = "Last Name:";
            // 
            // First_Name_label
            // 
            First_Name_label.AutoSize = true;
            First_Name_label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            First_Name_label.ForeColor = Color.WhiteSmoke;
            First_Name_label.Location = new Point(26, 127);
            First_Name_label.Name = "First_Name_label";
            First_Name_label.Size = new Size(119, 23);
            First_Name_label.TabIndex = 45;
            First_Name_label.Text = "First Name:";
            // 
            // Phone_TB
            // 
            Phone_TB.BackColor = Color.FromArgb(111, 76, 68);
            Phone_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phone_TB.ForeColor = Color.WhiteSmoke;
            Phone_TB.Location = new Point(150, 291);
            Phone_TB.Name = "Phone_TB";
            Phone_TB.Size = new Size(202, 30);
            Phone_TB.TabIndex = 52;
            // 
            // Email_TB
            // 
            Email_TB.BackColor = Color.FromArgb(111, 76, 68);
            Email_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email_TB.ForeColor = Color.WhiteSmoke;
            Email_TB.Location = new Point(150, 234);
            Email_TB.Name = "Email_TB";
            Email_TB.Size = new Size(202, 30);
            Email_TB.TabIndex = 51;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.FromArgb(111, 76, 68);
            Save_button.Cursor = Cursors.PanNW;
            Save_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save_button.ForeColor = Color.WhiteSmoke;
            Save_button.Location = new Point(502, 402);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(123, 37);
            Save_button.TabIndex = 54;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.BackColor = Color.FromArgb(111, 76, 68);
            Cancel_button.Cursor = Cursors.PanNW;
            Cancel_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_button.ForeColor = Color.WhiteSmoke;
            Cancel_button.Location = new Point(642, 402);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(123, 37);
            Cancel_button.TabIndex = 55;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = false;
            Cancel_button.Click += Cancel_button_Click_1;
            // 
            // Salary_TB
            // 
            Salary_TB.BackColor = Color.FromArgb(111, 76, 68);
            Salary_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary_TB.ForeColor = Color.WhiteSmoke;
            Salary_TB.Location = new Point(563, 69);
            Salary_TB.Name = "Salary_TB";
            Salary_TB.Size = new Size(202, 30);
            Salary_TB.TabIndex = 57;
            // 
            // Salary_Label
            // 
            Salary_Label.AutoSize = true;
            Salary_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salary_Label.ForeColor = Color.WhiteSmoke;
            Salary_Label.Location = new Point(451, 71);
            Salary_Label.Name = "Salary_Label";
            Salary_Label.Size = new Size(77, 23);
            Salary_Label.TabIndex = 56;
            Salary_Label.Text = "Salary:";
            // 
            // User_ID_Label
            // 
            User_ID_Label.AutoSize = true;
            User_ID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_ID_Label.ForeColor = Color.WhiteSmoke;
            User_ID_Label.Location = new Point(26, 70);
            User_ID_Label.Name = "User_ID_Label";
            User_ID_Label.Size = new Size(82, 23);
            User_ID_Label.TabIndex = 58;
            User_ID_Label.Text = "User ID:";
            // 
            // User_ID_L
            // 
            User_ID_L.BackColor = Color.FromArgb(51, 35, 31);
            User_ID_L.FlatStyle = FlatStyle.Flat;
            User_ID_L.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_ID_L.ForeColor = Color.WhiteSmoke;
            User_ID_L.Location = new Point(150, 69);
            User_ID_L.Name = "User_ID_L";
            User_ID_L.Size = new Size(202, 30);
            User_ID_L.TabIndex = 60;
            // 
            // UserID_Label
            // 
            UserID_Label.AutoSize = true;
            UserID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserID_Label.ForeColor = Color.WhiteSmoke;
            UserID_Label.Location = new Point(150, 70);
            UserID_Label.Name = "UserID_Label";
            UserID_Label.Size = new Size(77, 23);
            UserID_Label.TabIndex = 61;
            UserID_Label.Text = "User ID";
            // 
            // Clear_button
            // 
            Clear_button.BackColor = Color.FromArgb(51, 35, 31);
            Clear_button.BackgroundImage = (Image)resources.GetObject("Clear_button.BackgroundImage");
            Clear_button.BackgroundImageLayout = ImageLayout.Stretch;
            Clear_button.Cursor = Cursors.PanNW;
            Clear_button.FlatStyle = FlatStyle.Popup;
            Clear_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear_button.ForeColor = Color.WhiteSmoke;
            Clear_button.Location = new Point(436, 402);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(44, 39);
            Clear_button.TabIndex = 62;
            Clear_button.UseVisualStyleBackColor = false;
            Clear_button.Click += Clear_button_Click;
            // 
            // Add_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(790, 463);
            Controls.Add(Clear_button);
            Controls.Add(UserID_Label);
            Controls.Add(User_ID_L);
            Controls.Add(User_ID_Label);
            Controls.Add(Salary_TB);
            Controls.Add(Salary_Label);
            Controls.Add(Cancel_button);
            Controls.Add(Save_button);
            Controls.Add(Phone_TB);
            Controls.Add(Email_TB);
            Controls.Add(Last_Name_TB);
            Controls.Add(First_Name_TB);
            Controls.Add(Phone_label);
            Controls.Add(Email_label);
            Controls.Add(Last_Name_label);
            Controls.Add(First_Name_label);
            Controls.Add(pictureBox1);
            Controls.Add(Add_User_label);
            Controls.Add(Close_button_label);
            Controls.Add(Upload_button);
            Controls.Add(User_Image);
            Controls.Add(Status_CB);
            Controls.Add(Role_CB);
            Controls.Add(Password_TB);
            Controls.Add(Username_TB);
            Controls.Add(Status_Label);
            Controls.Add(Role_Label);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Users";
            Load += Add_Users_Load;
            ((System.ComponentModel.ISupportInitialize)User_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Upload_button;
        private PictureBox User_Image;
        private ComboBox Status_CB;
        private ComboBox Role_CB;
        private TextBox Password_TB;
        private TextBox Username_TB;
        private Label Status_Label;
        private Label Role_Label;
        private Label Password_Label;
        private Label Username_Label;
        private PictureBox pictureBox1;
        private Label Add_User_label;
        private Label Close_button_label;
        private TextBox Last_Name_TB;
        private TextBox First_Name_TB;
        private Label Phone_label;
        private Label Email_label;
        private Label Last_Name_label;
        private Label First_Name_label;
        private TextBox Phone_TB;
        private TextBox Email_TB;
        private Button Save_button;
        private Button Cancel_button;
        private TextBox Salary_TB;
        private Label Salary_Label;
        private Label User_ID_Label;
        private Label User_ID_L;
        private Label UserID_Label;
        private Button Clear_button;
    }
}