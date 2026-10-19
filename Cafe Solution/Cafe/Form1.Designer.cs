namespace Cafe
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Cafe_pic = new PictureBox();
            Close_button_label = new Label();
            Welcome_label = new Label();
            Min_button_label = new Label();
            Vintage_label = new Label();
            pictureBox1 = new PictureBox();
            Admin_button = new Button();
            Cashier_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Cafe_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Cafe_pic
            // 
            Cafe_pic.BackColor = Color.FromArgb(51, 35, 31);
            Cafe_pic.BackgroundImageLayout = ImageLayout.Stretch;
            Cafe_pic.Cursor = Cursors.PanNW;
            Cafe_pic.Image = (Image)resources.GetObject("Cafe_pic.Image");
            Cafe_pic.Location = new Point(13, 45);
            Cafe_pic.Name = "Cafe_pic";
            Cafe_pic.Size = new Size(764, 562);
            Cafe_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Cafe_pic.TabIndex = 4;
            Cafe_pic.TabStop = false;
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
            Close_button_label.TabIndex = 5;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Welcome_label
            // 
            Welcome_label.AutoSize = true;
            Welcome_label.Font = new Font("Pixelify Sans", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome_label.ForeColor = Color.White;
            Welcome_label.Location = new Point(139, 166);
            Welcome_label.Name = "Welcome_label";
            Welcome_label.Size = new Size(510, 49);
            Welcome_label.TabIndex = 6;
            Welcome_label.Text = "Welcome to Vintage Cafe !";
            Welcome_label.Click += Welcome_label_Click;
            // 
            // Min_button_label
            // 
            Min_button_label.AutoSize = true;
            Min_button_label.FlatStyle = FlatStyle.Flat;
            Min_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Min_button_label.ForeColor = Color.White;
            Min_button_label.Location = new Point(706, 10);
            Min_button_label.Name = "Min_button_label";
            Min_button_label.Size = new Size(26, 31);
            Min_button_label.TabIndex = 7;
            Min_button_label.Text = "_";
            Min_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Min_button_label.Click += Min_button_label_Click;
            // 
            // Vintage_label
            // 
            Vintage_label.AutoSize = true;
            Vintage_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vintage_label.ForeColor = Color.White;
            Vintage_label.Location = new Point(48, 18);
            Vintage_label.Name = "Vintage_label";
            Vintage_label.Size = new Size(114, 20);
            Vintage_label.TabIndex = 8;
            Vintage_label.Text = "Vintage Cafe";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Admin_button
            // 
            Admin_button.AutoEllipsis = true;
            Admin_button.BackColor = Color.FromArgb(51, 35, 31);
            Admin_button.Cursor = Cursors.PanNW;
            Admin_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Admin_button.ForeColor = Color.WhiteSmoke;
            Admin_button.Location = new Point(318, 276);
            Admin_button.Name = "Admin_button";
            Admin_button.Size = new Size(161, 62);
            Admin_button.TabIndex = 10;
            Admin_button.Text = "Admin";
            Admin_button.UseVisualStyleBackColor = false;
            Admin_button.Click += Admin_button_Click;
            // 
            // Cashier_button
            // 
            Cashier_button.BackColor = Color.FromArgb(51, 35, 31);
            Cashier_button.Cursor = Cursors.PanNW;
            Cashier_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier_button.ForeColor = Color.WhiteSmoke;
            Cashier_button.Location = new Point(318, 344);
            Cashier_button.Name = "Cashier_button";
            Cashier_button.Size = new Size(161, 62);
            Cashier_button.TabIndex = 11;
            Cashier_button.Text = "Cashier";
            Cashier_button.UseVisualStyleBackColor = false;
            Cashier_button.Click += Cashier_button_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 620);
            Controls.Add(Cashier_button);
            Controls.Add(Admin_button);
            Controls.Add(pictureBox1);
            Controls.Add(Vintage_label);
            Controls.Add(Min_button_label);
            Controls.Add(Welcome_label);
            Controls.Add(Close_button_label);
            Controls.Add(Cafe_pic);
            Cursor = Cursors.PanNW;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cinnamon & Co.";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)Cafe_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Cafe_pic;
        private Label Close_button_label;
        private Label Welcome_label;
        private Label Min_button_label;
        private Label Vintage_label;
        private PictureBox pictureBox1;
        private Button Admin_button;
        private Button Cashier_button;
    }
}
