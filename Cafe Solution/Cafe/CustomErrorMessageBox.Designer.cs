namespace Cafe
{
    partial class CustomErrorMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomErrorMessageBox));
            Close_button_label = new Label();
            pictureBox1 = new PictureBox();
            Vintage_label = new Label();
            pictureBox2 = new PictureBox();
            No_button = new Button();
            Yes_button = new Button();
            Okay_button = new Button();
            Message_Title = new Label();
            Message = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.BackColor = Color.FromArgb(51, 35, 31);
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(432, 9);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 13;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(51, 35, 31);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Vintage_label
            // 
            Vintage_label.AutoSize = true;
            Vintage_label.BackColor = Color.FromArgb(51, 35, 31);
            Vintage_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vintage_label.ForeColor = Color.White;
            Vintage_label.Location = new Point(49, 14);
            Vintage_label.Name = "Vintage_label";
            Vintage_label.Size = new Size(134, 20);
            Vintage_label.TabIndex = 14;
            Vintage_label.Text = "Error Message";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(51, 35, 31);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(18, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 101);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // No_button
            // 
            No_button.BackColor = Color.FromArgb(111, 76, 68);
            No_button.Cursor = Cursors.PanNW;
            No_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            No_button.ForeColor = Color.WhiteSmoke;
            No_button.Location = new Point(261, 213);
            No_button.Name = "No_button";
            No_button.Size = new Size(167, 37);
            No_button.TabIndex = 21;
            No_button.Text = "No";
            No_button.UseVisualStyleBackColor = false;
            No_button.Click += No_button_Click;
            // 
            // Yes_button
            // 
            Yes_button.BackColor = Color.FromArgb(111, 76, 68);
            Yes_button.Cursor = Cursors.PanNW;
            Yes_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yes_button.ForeColor = Color.WhiteSmoke;
            Yes_button.Location = new Point(38, 213);
            Yes_button.Name = "Yes_button";
            Yes_button.Size = new Size(167, 37);
            Yes_button.TabIndex = 23;
            Yes_button.Text = "Yes";
            Yes_button.UseVisualStyleBackColor = false;
            Yes_button.Click += Yes_button_Click;
            // 
            // Okay_button
            // 
            Okay_button.BackColor = Color.FromArgb(111, 76, 68);
            Okay_button.Cursor = Cursors.PanNW;
            Okay_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Okay_button.ForeColor = Color.WhiteSmoke;
            Okay_button.Location = new Point(261, 213);
            Okay_button.Name = "Okay_button";
            Okay_button.Size = new Size(167, 37);
            Okay_button.TabIndex = 24;
            Okay_button.Text = "Okay";
            Okay_button.UseVisualStyleBackColor = false;
            Okay_button.Click += Okay_button_Click;
            // 
            // Message_Title
            // 
            Message_Title.AutoSize = true;
            Message_Title.BackColor = Color.FromArgb(51, 35, 31);
            Message_Title.Font = new Font("Pixelify Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Message_Title.ForeColor = Color.WhiteSmoke;
            Message_Title.Location = new Point(14, 45);
            Message_Title.Name = "Message_Title";
            Message_Title.Size = new Size(177, 29);
            Message_Title.TabIndex = 25;
            Message_Title.Text = "Message Title";
            // 
            // Message
            // 
            Message.BackColor = Color.FromArgb(51, 35, 31);
            Message.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message.ForeColor = Color.WhiteSmoke;
            Message.Location = new Point(154, 86);
            Message.Name = "Message";
            Message.Size = new Size(295, 101);
            Message.TabIndex = 26;
            Message.Text = "Message";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(51, 35, 31);
            pictureBox3.Location = new Point(5, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(460, 267);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // CustomErrorMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 76, 68);
            ClientSize = new Size(470, 277);
            Controls.Add(Message);
            Controls.Add(Message_Title);
            Controls.Add(Okay_button);
            Controls.Add(Yes_button);
            Controls.Add(No_button);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Vintage_label);
            Controls.Add(Close_button_label);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomErrorMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomErrorMessageBox";
            Load += CustomErrorMessageBox_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Close_button_label;
        private PictureBox pictureBox1;
        private Label Vintage_label;
        private PictureBox pictureBox2;
        private Button No_button;
        private Button Yes_button;
        private Button Okay_button;
        private Label Message_Title;
        private Label Message;
        private PictureBox pictureBox3;
    }
}