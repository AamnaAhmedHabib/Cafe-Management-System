namespace Cafe
{
    partial class Cashier_view
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_view));
            pictureBox1 = new PictureBox();
            Vintage_label = new Label();
            Min_button_label = new Label();
            Close_button_label = new Label();
            Dashboard_LB = new Label();
            Customer_LB = new Label();
            CafeIn_pic = new PictureBox();
            toolTip = new ToolTip(components);
            Logout_rug = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CafeIn_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logout_rug).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Vintage_label
            // 
            Vintage_label.AutoSize = true;
            Vintage_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vintage_label.ForeColor = Color.White;
            Vintage_label.Location = new Point(48, 18);
            Vintage_label.Name = "Vintage_label";
            Vintage_label.Size = new Size(250, 20);
            Vintage_label.TabIndex = 12;
            Vintage_label.Text = "Vintage Cafe - Cashier Portal";
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
            Min_button_label.TabIndex = 11;
            Min_button_label.Text = "_";
            Min_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Min_button_label.Click += Min_button_label_Click;
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
            Close_button_label.TabIndex = 10;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Dashboard_LB
            // 
            Dashboard_LB.Cursor = Cursors.PanNW;
            Dashboard_LB.Font = new Font("Pixelify Sans", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_LB.ForeColor = Color.White;
            Dashboard_LB.Location = new Point(167, 277);
            Dashboard_LB.Name = "Dashboard_LB";
            Dashboard_LB.Size = new Size(132, 64);
            Dashboard_LB.TabIndex = 22;
            Dashboard_LB.Click += Dashboard_LB_Click;
            Dashboard_LB.MouseHover += Dashboard_LB_Hover;
            // 
            // Customer_LB
            // 
            Customer_LB.Cursor = Cursors.PanNW;
            Customer_LB.Font = new Font("Pixelify Sans", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_LB.ForeColor = Color.White;
            Customer_LB.Location = new Point(256, 407);
            Customer_LB.Name = "Customer_LB";
            Customer_LB.Size = new Size(116, 130);
            Customer_LB.TabIndex = 19;
            Customer_LB.Click += Customer_LB_Click;
            Customer_LB.MouseHover += Customer_LB_Hover;
            // 
            // CafeIn_pic
            // 
            CafeIn_pic.BackColor = Color.FromArgb(68, 17, 17, 144);
            CafeIn_pic.BackgroundImageLayout = ImageLayout.Stretch;
            CafeIn_pic.Cursor = Cursors.PanNW;
            CafeIn_pic.Image = (Image)resources.GetObject("CafeIn_pic.Image");
            CafeIn_pic.Location = new Point(13, 45);
            CafeIn_pic.Name = "CafeIn_pic";
            CafeIn_pic.Size = new Size(764, 562);
            CafeIn_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            CafeIn_pic.TabIndex = 18;
            CafeIn_pic.TabStop = false;
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.OwnerDraw = true;
            toolTip.Draw += toolTip_Draw;
            toolTip.Popup += toolTip_Popup;
            // 
            // Logout_rug
            // 
            Logout_rug.BackgroundImage = (Image)resources.GetObject("Logout_rug.BackgroundImage");
            Logout_rug.BackgroundImageLayout = ImageLayout.Stretch;
            Logout_rug.Location = new Point(682, 499);
            Logout_rug.Name = "Logout_rug";
            Logout_rug.Size = new Size(86, 93);
            Logout_rug.TabIndex = 23;
            Logout_rug.TabStop = false;
            Logout_rug.Click += Logout_rug_Click;
            Logout_rug.MouseHover += Logout_rug_Hover;
            // 
            // Cashier_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(790, 620);
            Controls.Add(Logout_rug);
            Controls.Add(Dashboard_LB);
            Controls.Add(Customer_LB);
            Controls.Add(CafeIn_pic);
            Controls.Add(pictureBox1);
            Controls.Add(Vintage_label);
            Controls.Add(Min_button_label);
            Controls.Add(Close_button_label);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cashier_view";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier_view";
            Load += Cashier_view_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CafeIn_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logout_rug).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Vintage_label;
        private Label Min_button_label;
        private Label Close_button_label;
        private Label Dashboard_LB;
        private Label Customer_LB;
        private PictureBox CafeIn_pic;
        private ToolTip toolTip;
        private PictureBox Logout_rug;
    }
}