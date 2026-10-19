namespace Cafe
{
    partial class Cashier_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_SignIn));
            White_BG = new PictureBox();
            Pixie_BG = new PictureBox();
            Coffee_Cashier_Login = new PictureBox();
            Close_button_label = new Label();
            Login_button = new Button();
            ShowPassword_CB = new CheckBox();
            Password_TB = new TextBox();
            Password_label = new Label();
            Username_TB = new TextBox();
            Username_label = new Label();
            Cashier_SignIn_label = new Label();
            ((System.ComponentModel.ISupportInitialize)White_BG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pixie_BG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coffee_Cashier_Login).BeginInit();
            SuspendLayout();
            // 
            // White_BG
            // 
            White_BG.BackColor = Color.White;
            White_BG.Location = new Point(12, 12);
            White_BG.Name = "White_BG";
            White_BG.Size = new Size(448, 596);
            White_BG.TabIndex = 10;
            White_BG.TabStop = false;
            // 
            // Pixie_BG
            // 
            Pixie_BG.Location = new Point(20, 20);
            Pixie_BG.Name = "Pixie_BG";
            Pixie_BG.Size = new Size(433, 580);
            Pixie_BG.TabIndex = 11;
            Pixie_BG.TabStop = false;
            // 
            // Coffee_Cashier_Login
            // 
            Coffee_Cashier_Login.BackgroundImage = (Image)resources.GetObject("Coffee_Cashier_Login.BackgroundImage");
            Coffee_Cashier_Login.BackgroundImageLayout = ImageLayout.Stretch;
            Coffee_Cashier_Login.Location = new Point(145, 22);
            Coffee_Cashier_Login.Name = "Coffee_Cashier_Login";
            Coffee_Cashier_Login.Size = new Size(167, 186);
            Coffee_Cashier_Login.TabIndex = 12;
            Coffee_Cashier_Login.TabStop = false;
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
            Close_button_label.TabIndex = 13;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
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
            Login_button.TabIndex = 22;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = false;
            Login_button.Click += Login_button_Click;
            // 
            // ShowPassword_CB
            // 
            ShowPassword_CB.AutoSize = true;
            ShowPassword_CB.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword_CB.ForeColor = Color.WhiteSmoke;
            ShowPassword_CB.Location = new Point(92, 422);
            ShowPassword_CB.Name = "ShowPassword_CB";
            ShowPassword_CB.Size = new Size(156, 24);
            ShowPassword_CB.TabIndex = 21;
            ShowPassword_CB.Text = "Show Password";
            ShowPassword_CB.UseVisualStyleBackColor = true;
            ShowPassword_CB.CheckedChanged += ShowPassword_CB_CheckedChanged;
            // 
            // Password_TB
            // 
            Password_TB.BackColor = Color.WhiteSmoke;
            Password_TB.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_TB.Location = new Point(92, 393);
            Password_TB.Name = "Password_TB";
            Password_TB.PasswordChar = '*';
            Password_TB.Size = new Size(276, 30);
            Password_TB.TabIndex = 20;
            // 
            // Password_label
            // 
            Password_label.AutoSize = true;
            Password_label.Font = new Font("Pixelify Sans SemBd", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_label.ForeColor = Color.WhiteSmoke;
            Password_label.Location = new Point(175, 366);
            Password_label.Name = "Password_label";
            Password_label.Size = new Size(108, 24);
            Password_label.TabIndex = 19;
            Password_label.Text = "Password";
            // 
            // Username_TB
            // 
            Username_TB.BackColor = Color.WhiteSmoke;
            Username_TB.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_TB.Location = new Point(92, 307);
            Username_TB.Name = "Username_TB";
            Username_TB.Size = new Size(276, 30);
            Username_TB.TabIndex = 18;
            // 
            // Username_label
            // 
            Username_label.AutoSize = true;
            Username_label.Font = new Font("Pixelify Sans SemBd", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_label.ForeColor = Color.WhiteSmoke;
            Username_label.Location = new Point(175, 280);
            Username_label.Name = "Username_label";
            Username_label.Size = new Size(109, 24);
            Username_label.TabIndex = 17;
            Username_label.Text = "Username";
            // 
            // Cashier_SignIn_label
            // 
            Cashier_SignIn_label.AutoSize = true;
            Cashier_SignIn_label.Font = new Font("Pixelify Sans SemiBold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_SignIn_label.ForeColor = Color.WhiteSmoke;
            Cashier_SignIn_label.Location = new Point(122, 208);
            Cashier_SignIn_label.Name = "Cashier_SignIn_label";
            Cashier_SignIn_label.Size = new Size(212, 33);
            Cashier_SignIn_label.TabIndex = 16;
            Cashier_SignIn_label.Text = "Cashier Sign-In";
            // 
            // Cashier_SignIn
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
            Controls.Add(Cashier_SignIn_label);
            Controls.Add(Close_button_label);
            Controls.Add(Coffee_Cashier_Login);
            Controls.Add(Pixie_BG);
            Controls.Add(White_BG);
            Cursor = Cursors.PanNW;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cashier_SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier_SignIn";
            ((System.ComponentModel.ISupportInitialize)White_BG).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pixie_BG).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coffee_Cashier_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox White_BG;
        private PictureBox Pixie_BG;
        private PictureBox Coffee_Cashier_Login;
        private Label Close_button_label;
        private Button Login_button;
        private CheckBox ShowPassword_CB;
        private TextBox Password_TB;
        private Label Password_label;
        private TextBox Username_TB;
        private Label Username_label;
        private Label Cashier_SignIn_label;
    }
}