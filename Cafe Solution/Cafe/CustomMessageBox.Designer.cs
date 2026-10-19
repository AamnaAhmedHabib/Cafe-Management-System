namespace Cafe
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            Cafe_logo = new PictureBox();
            Add_Item_label = new Label();
            Close_button_label = new Label();
            Food_Image = new PictureBox();
            Food_category_CB = new ComboBox();
            Item_Name_TB = new TextBox();
            Category_Label = new Label();
            Item_Name_Label = new Label();
            Item_ID_Label = new Label();
            Upload_button = new Button();
            Price_TB = new TextBox();
            Price_Label = new Label();
            ItemID_Label = new Label();
            Clear_button = new Button();
            Save_button = new Button();
            ((System.ComponentModel.ISupportInitialize)Cafe_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Food_Image).BeginInit();
            SuspendLayout();
            // 
            // Cafe_logo
            // 
            Cafe_logo.BackgroundImage = (Image)resources.GetObject("Cafe_logo.BackgroundImage");
            Cafe_logo.BackgroundImageLayout = ImageLayout.Stretch;
            Cafe_logo.Location = new Point(12, 12);
            Cafe_logo.Name = "Cafe_logo";
            Cafe_logo.Size = new Size(30, 30);
            Cafe_logo.TabIndex = 11;
            Cafe_logo.TabStop = false;
            // 
            // Add_Item_label
            // 
            Add_Item_label.AutoSize = true;
            Add_Item_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Item_label.ForeColor = Color.White;
            Add_Item_label.Location = new Point(48, 18);
            Add_Item_label.Name = "Add_Item_label";
            Add_Item_label.Size = new Size(82, 20);
            Add_Item_label.TabIndex = 10;
            Add_Item_label.Text = "Add Item";
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(623, 14);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 12;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Food_Image
            // 
            Food_Image.BackgroundImageLayout = ImageLayout.Stretch;
            Food_Image.BorderStyle = BorderStyle.FixedSingle;
            Food_Image.Location = new Point(458, 87);
            Food_Image.Name = "Food_Image";
            Food_Image.Size = new Size(167, 167);
            Food_Image.TabIndex = 13;
            Food_Image.TabStop = false;
            // 
            // Food_category_CB
            // 
            Food_category_CB.BackColor = Color.FromArgb(111, 76, 68);
            Food_category_CB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Food_category_CB.ForeColor = Color.WhiteSmoke;
            Food_category_CB.FormattingEnabled = true;
            Food_category_CB.Items.AddRange(new object[] { "Food", "Beverage" });
            Food_category_CB.Location = new Point(177, 201);
            Food_category_CB.Name = "Food_category_CB";
            Food_category_CB.Size = new Size(202, 31);
            Food_category_CB.TabIndex = 19;
            // 
            // Item_Name_TB
            // 
            Item_Name_TB.BackColor = Color.FromArgb(111, 76, 68);
            Item_Name_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Item_Name_TB.ForeColor = Color.WhiteSmoke;
            Item_Name_TB.Location = new Point(177, 144);
            Item_Name_TB.Name = "Item_Name_TB";
            Item_Name_TB.Size = new Size(202, 30);
            Item_Name_TB.TabIndex = 18;
            // 
            // Category_Label
            // 
            Category_Label.AutoSize = true;
            Category_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_Label.ForeColor = Color.WhiteSmoke;
            Category_Label.Location = new Point(26, 204);
            Category_Label.Name = "Category_Label";
            Category_Label.Size = new Size(103, 23);
            Category_Label.TabIndex = 16;
            Category_Label.Text = "Category:";
            // 
            // Item_Name_Label
            // 
            Item_Name_Label.AutoSize = true;
            Item_Name_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Item_Name_Label.ForeColor = Color.WhiteSmoke;
            Item_Name_Label.Location = new Point(26, 147);
            Item_Name_Label.Name = "Item_Name_Label";
            Item_Name_Label.Size = new Size(114, 23);
            Item_Name_Label.TabIndex = 15;
            Item_Name_Label.Text = "Item Name:";
            // 
            // Item_ID_Label
            // 
            Item_ID_Label.AutoSize = true;
            Item_ID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Item_ID_Label.ForeColor = Color.WhiteSmoke;
            Item_ID_Label.Location = new Point(26, 90);
            Item_ID_Label.Name = "Item_ID_Label";
            Item_ID_Label.Size = new Size(84, 23);
            Item_ID_Label.TabIndex = 14;
            Item_ID_Label.Text = "Item ID:";
            Item_ID_Label.Click += Username_Label_Click;
            // 
            // Upload_button
            // 
            Upload_button.BackColor = Color.FromArgb(111, 76, 68);
            Upload_button.Cursor = Cursors.PanNW;
            Upload_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Upload_button.ForeColor = Color.WhiteSmoke;
            Upload_button.Location = new Point(458, 269);
            Upload_button.Name = "Upload_button";
            Upload_button.Size = new Size(167, 37);
            Upload_button.TabIndex = 20;
            Upload_button.Text = "Upload";
            Upload_button.UseVisualStyleBackColor = false;
            Upload_button.Click += Upload_button_Click;
            // 
            // Price_TB
            // 
            Price_TB.BackColor = Color.FromArgb(111, 76, 68);
            Price_TB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price_TB.ForeColor = Color.WhiteSmoke;
            Price_TB.Location = new Point(177, 258);
            Price_TB.Name = "Price_TB";
            Price_TB.Size = new Size(202, 30);
            Price_TB.TabIndex = 26;
            // 
            // Price_Label
            // 
            Price_Label.AutoSize = true;
            Price_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price_Label.ForeColor = Color.WhiteSmoke;
            Price_Label.Location = new Point(26, 262);
            Price_Label.Name = "Price_Label";
            Price_Label.Size = new Size(62, 23);
            Price_Label.TabIndex = 25;
            Price_Label.Text = "Price:";
            // 
            // ItemID_Label
            // 
            ItemID_Label.AutoSize = true;
            ItemID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemID_Label.ForeColor = Color.WhiteSmoke;
            ItemID_Label.Location = new Point(177, 90);
            ItemID_Label.Name = "ItemID_Label";
            ItemID_Label.Size = new Size(79, 23);
            ItemID_Label.TabIndex = 28;
            ItemID_Label.Text = "Item ID";
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
            Clear_button.Location = new Point(26, 354);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(44, 39);
            Clear_button.TabIndex = 24;
            Clear_button.UseVisualStyleBackColor = false;
            Clear_button.Click += Clear_button_Click;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.FromArgb(111, 76, 68);
            Save_button.Cursor = Cursors.PanNW;
            Save_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save_button.ForeColor = Color.WhiteSmoke;
            Save_button.Location = new Point(458, 356);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(167, 37);
            Save_button.TabIndex = 55;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(665, 423);
            Controls.Add(Save_button);
            Controls.Add(ItemID_Label);
            Controls.Add(Price_TB);
            Controls.Add(Price_Label);
            Controls.Add(Clear_button);
            Controls.Add(Upload_button);
            Controls.Add(Food_category_CB);
            Controls.Add(Item_Name_TB);
            Controls.Add(Category_Label);
            Controls.Add(Item_Name_Label);
            Controls.Add(Item_ID_Label);
            Controls.Add(Food_Image);
            Controls.Add(Close_button_label);
            Controls.Add(Cafe_logo);
            Controls.Add(Add_Item_label);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomMessageBox";
            Load += CustomMessageBox_Load;
            ((System.ComponentModel.ISupportInitialize)Cafe_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Food_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Cafe_logo;
        private Label Add_Item_label;
        private Label Close_button_label;
        private PictureBox Food_Image;
        private ComboBox Food_category_CB;
        private TextBox Item_Name_TB;
        private Label Category_Label;
        private Label Item_Name_Label;
        private Label Item_ID_Label;
        private Button Upload_button;
        private TextBox Price_TB;
        private Label Price_Label;
        private Label ItemID_Label;
        private Button Clear_button;
        private Button Save_button;
    }
}