namespace Cafe
{
    partial class Admin_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_SignIn));
            Coffee_Admin_Login = new PictureBox();
            Close_button_label = new Label();
            Admin_SignIn_label = new Label();
            Username_label = new Label();
            White_BG = new PictureBox();
            Pixie_BG = new PictureBox();
            Username_TB = new TextBox();
            Password_TB = new TextBox();
            Password_label = new Label();
            ShowPassword_CB = new CheckBox();
            Login_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Coffee_Admin_Login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)White_BG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pixie_BG).BeginInit();
            SuspendLayout();
            // 
            // Coffee_Admin_Login
            // 
            Coffee_Admin_Login.BackgroundImage = (Image)resources.GetObject("Coffee_Admin_Login.BackgroundImage");
            Coffee_Admin_Login.BackgroundImageLayout = ImageLayout.Stretch;
            Coffee_Admin_Login.Location = new Point(145, 22);
            Coffee_Admin_Login.Name = "Coffee_Admin_Login";
            Coffee_Admin_Login.Size = new Size(167, 186);
            Coffee_Admin_Login.TabIndex = 0;
            Coffee_Admin_Login.TabStop = false;
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(440, 2);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 6;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_Click;
            // 
            // Admin_SignIn_label
            // 
            Admin_SignIn_label.AutoSize = true;
            Admin_SignIn_label.Font = new Font("Pixelify Sans SemiBold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_SignIn_label.ForeColor = Color.WhiteSmoke;
            Admin_SignIn_label.Location = new Point(137, 210);
            Admin_SignIn_label.Name = "Admin_SignIn_label";
            Admin_SignIn_label.Size = new Size(182, 33);
            Admin_SignIn_label.TabIndex = 7;
            Admin_SignIn_label.Text = "Admin Sign-In";
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Font = new Font("Pixelify Sans SemBd", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_label.ForeColor = Color.WhiteSmoke;
            Username_label.Location = new Point(175, 280);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(109, 24);
            Username_label.TabIndex = 8;
            Username_label.Text = "Username";
            // 
            // White_BG
            // 
            White_BG.BackColor = Color.White;
            White_BG.Location = new Point(12, 12);
            White_BG.Name = "White_BG";
            White_BG.Size = new Size(448, 596);
            White_BG.TabIndex = 9;
            White_BG.TabStop = false;
            // 
            // Pixie_BG
            // 
            Pixie_BG.Location = new Point(20, 20);
            Pixie_BG.Name = "Pixie_BG";
            Pixie_BG.Size = new Size(433, 580);
            Pixie_BG.TabIndex = 10;
            Pixie_BG.TabStop = false;
            // 
            // Username_TB
            // 
            Username_TB.BackColor = Color.WhiteSmoke;
            Username_TB.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_TB.Location = new Point(92, 307);
            Username_TB.Name = "Username_TB";
            Username_TB.Size = new Size(276, 30);
            Username_TB.TabIndex = 11;
            // 
            // Password_TB
            // 
            Password_TB.BackColor = Color.WhiteSmoke;
            Password_TB.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_TB.Location = new Point(92, 393);
            Password_TB.Name = "Password_TB";
            Password_TB.PasswordChar = '*';
            Password_TB.Size = new Size(276, 30);
            Password_TB.TabIndex = 13;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Font = new Font("Pixelify Sans SemBd", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_label.ForeColor = Color.WhiteSmoke;
            Password_label.Location = new Point(175, 366);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(108, 24);
            Password_label.TabIndex = 12;
            Password_label.Text = "Password";
            // 
            // ShowPassword_CB
            // 
            ShowPassword_CB.AutoSize = true;
            ShowPassword_CB.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword_CB.ForeColor = Color.WhiteSmoke;
            ShowPassword_CB.Location = new Point(92, 422);
            ShowPassword_CB.Name = "ShowPassword_CB";
            ShowPassword_CB.Size = new Size(156, 24);
            ShowPassword_CB.TabIndex = 14;
            ShowPassword_CB.Text = "Show Password";
            ShowPassword_CB.UseVisualStyleBackColor = true;
            ShowPassword_CB.CheckedChanged += ShowPassword_CB_CheckedChanged;
            // 
            // Login_button
            // 
            Login_button.BackColor = Color.WhiteSmoke;
            Login_button.FlatStyle = FlatStyle.Flat;
            Login_button.Font = new Font("Pixelify Sans SemBd", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.ForeColor = Color.FromArgb(51, 35, 31);
            Login_button.Location = new Point(146, 504);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(167, 60);
            Login_button.TabIndex = 15;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // Admin_SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(472, 620);
            Controls.Add(Login_button);
            Controls.Add(ShowPassword_CB);
            Controls.Add(Password_TB);
            Controls.Add(Password_label);
            Controls.Add(Username_TB);
            Controls.Add(Username_label);
            Controls.Add(Admin_SignIn_label);
            Controls.Add(Close_button_label);
            Controls.Add(Coffee_Admin_Login);
            Controls.Add(Pixie_BG);
            Controls.Add(White_BG);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_SignIn";
            ((System.ComponentModel.ISupportInitialize)Coffee_Admin_Login).EndInit();
            ((System.ComponentModel.ISupportInitialize)White_BG).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pixie_BG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Coffee_Admin_Login;
        private Label Close_button_label;
        private Label Admin_SignIn_label;
        private Label Username_label;
        private PictureBox White_BG;
        private PictureBox Pixie_BG;
        private TextBox Username_TB;
        private TextBox Password_TB;
        private Label Password_label;
        private CheckBox ShowPassword_CB;
        private Button Login_button;
    }
}