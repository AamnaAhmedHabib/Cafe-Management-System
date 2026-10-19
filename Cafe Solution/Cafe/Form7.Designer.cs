namespace Cafe
{
    partial class Add_Products_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Products_Menu));
            Vintage_label = new Label();
            Close_button_label = new Label();
            Notepad = new PictureBox();
            Add_button = new Button();
            Back_label_button = new Label();
            Menu_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)Notepad).BeginInit();
            SuspendLayout();
            // 
            // Vintage_label
            // 
            Vintage_label.AutoSize = true;
            Vintage_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vintage_label.ForeColor = Color.White;
            Vintage_label.Location = new Point(48, 18);
            Vintage_label.Name = "Vintage_label";
            Vintage_label.Size = new Size(242, 20);
            Vintage_label.TabIndex = 12;
            Vintage_label.Text = "Add Products - Admin Portal ";
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(460, 9);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 10;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Notepad
            // 
            Notepad.BackColor = Color.FromArgb(51, 35, 31);
            Notepad.BackgroundImage = (Image)resources.GetObject("Notepad.BackgroundImage");
            Notepad.BackgroundImageLayout = ImageLayout.Stretch;
            Notepad.Location = new Point(13, 54);
            Notepad.Name = "Notepad";
            Notepad.Size = new Size(477, 558);
            Notepad.TabIndex = 14;
            Notepad.TabStop = false;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.FromArgb(51, 35, 31);
            Add_button.Cursor = Cursors.PanNW;
            Add_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = Color.WhiteSmoke;
            Add_button.Location = new Point(173, 621);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(161, 49);
            Add_button.TabIndex = 33;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click;
            // 
            // Back_label_button
            // 
            Back_label_button.Cursor = Cursors.PanNW;
            Back_label_button.FlatStyle = FlatStyle.Flat;
            Back_label_button.Font = new Font("Pixelify Sans SemBd", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_label_button.ForeColor = Color.White;
            Back_label_button.Location = new Point(13, 13);
            Back_label_button.Name = "Back_label_button";
            Back_label_button.Size = new Size(30, 30);
            Back_label_button.TabIndex = 34;
            Back_label_button.Text = "<";
            Back_label_button.TextAlign = ContentAlignment.MiddleCenter;
            Back_label_button.Click += Back_label_button_Click;
            // 
            // Menu_panel
            // 
            Menu_panel.AutoScroll = true;
            Menu_panel.BackColor = Color.FromArgb(255, 233, 173);
            Menu_panel.Location = new Point(31, 132);
            Menu_panel.Name = "Menu_panel";
            Menu_panel.Size = new Size(454, 475);
            Menu_panel.TabIndex = 35;
            // 
            // Add_Products_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(502, 678);
            Controls.Add(Menu_panel);
            Controls.Add(Add_button);
            Controls.Add(Back_label_button);
            Controls.Add(Notepad);
            Controls.Add(Vintage_label);
            Controls.Add(Close_button_label);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_Products_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Products_Menu";
            ((System.ComponentModel.ISupportInitialize)Notepad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Vintage_label;
        private Label Close_button_label;
        private PictureBox Notepad;
        private Button Add_button;
        private Label Back_label_button;
        private Panel Menu_panel;
    }
}