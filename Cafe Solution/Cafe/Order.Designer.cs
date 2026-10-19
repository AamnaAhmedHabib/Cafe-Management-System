namespace Cafe
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            Order_PB = new PictureBox();
            Back_label_button = new Label();
            Vintage_label = new Label();
            Close_button_label = new Label();
            Customer_ID_Label = new Label();
            Done_button = new Button();
            Customer_ID_L = new Label();
            Server_ID_Label = new Label();
            Order_Category_Label = new Label();
            Order_category_CB = new ComboBox();
            Total_Items_Label = new Label();
            Total_Bill_Label = new Label();
            Payment_Label = new Label();
            Payment_CB = new ComboBox();
            Order_ID_Label = new Label();
            Menu_panel = new Panel();
            OrderID_Label = new Label();
            TotalBill_Label = new Label();
            TotalItems_Label = new Label();
            ServerID_Label = new Label();
            CustomerID_Label = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)Order_PB).BeginInit();
            SuspendLayout();
            // 
            // Order_PB
            // 
            Order_PB.BackgroundImage = (Image)resources.GetObject("Order_PB.BackgroundImage");
            Order_PB.BackgroundImageLayout = ImageLayout.Stretch;
            Order_PB.Location = new Point(13, 49);
            Order_PB.Name = "Order_PB";
            Order_PB.Size = new Size(477, 558);
            Order_PB.TabIndex = 0;
            Order_PB.TabStop = false;
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
            Back_label_button.TabIndex = 37;
            Back_label_button.Text = "<";
            Back_label_button.TextAlign = ContentAlignment.MiddleCenter;
            Back_label_button.Click += Back_label_button_Click;
            // 
            // Vintage_label
            // 
            Vintage_label.AutoSize = true;
            Vintage_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vintage_label.ForeColor = Color.White;
            Vintage_label.Location = new Point(48, 18);
            Vintage_label.Name = "Vintage_label";
            Vintage_label.Size = new Size(198, 20);
            Vintage_label.TabIndex = 36;
            Vintage_label.Text = "Order - Cashier Portal ";
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(730, 13);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 35;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Customer_ID_Label
            // 
            Customer_ID_Label.AutoSize = true;
            Customer_ID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Customer_ID_Label.ForeColor = Color.WhiteSmoke;
            Customer_ID_Label.Location = new Point(495, 167);
            Customer_ID_Label.Name = "Customer_ID_Label";
            Customer_ID_Label.Size = new Size(131, 23);
            Customer_ID_Label.TabIndex = 40;
            Customer_ID_Label.Text = "Customer ID:";
            // 
            // Done_button
            // 
            Done_button.BackColor = Color.FromArgb(51, 35, 31);
            Done_button.Cursor = Cursors.PanNW;
            Done_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Done_button.ForeColor = Color.WhiteSmoke;
            Done_button.Location = new Point(574, 555);
            Done_button.Name = "Done_button";
            Done_button.Size = new Size(133, 38);
            Done_button.TabIndex = 42;
            Done_button.Text = "Done";
            Done_button.UseVisualStyleBackColor = false;
            Done_button.Click += Done_button_Click;
            // 
            // Customer_ID_L
            // 
            Customer_ID_L.BackColor = Color.FromArgb(51, 35, 31);
            Customer_ID_L.FlatStyle = FlatStyle.Flat;
            Customer_ID_L.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Customer_ID_L.ForeColor = Color.WhiteSmoke;
            Customer_ID_L.Location = new Point(154, 626);
            Customer_ID_L.Name = "Customer_ID_L";
            Customer_ID_L.Size = new Size(169, 30);
            Customer_ID_L.TabIndex = 43;
            // 
            // Server_ID_Label
            // 
            Server_ID_Label.AutoSize = true;
            Server_ID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Server_ID_Label.ForeColor = Color.WhiteSmoke;
            Server_ID_Label.Location = new Point(495, 231);
            Server_ID_Label.Name = "Server_ID_Label";
            Server_ID_Label.Size = new Size(102, 23);
            Server_ID_Label.TabIndex = 44;
            Server_ID_Label.Text = "Server ID:";
            // 
            // Order_Category_Label
            // 
            Order_Category_Label.AutoSize = true;
            Order_Category_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_Category_Label.ForeColor = Color.WhiteSmoke;
            Order_Category_Label.Location = new Point(495, 295);
            Order_Category_Label.Name = "Order_Category_Label";
            Order_Category_Label.Size = new Size(103, 23);
            Order_Category_Label.TabIndex = 45;
            Order_Category_Label.Text = "Category:";
            // 
            // Order_category_CB
            // 
            Order_category_CB.BackColor = Color.FromArgb(111, 76, 68);
            Order_category_CB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Order_category_CB.ForeColor = Color.WhiteSmoke;
            Order_category_CB.FormattingEnabled = true;
            Order_category_CB.Items.AddRange(new object[] { "Dine-In", "Takeaway" });
            Order_category_CB.Location = new Point(604, 292);
            Order_category_CB.Name = "Order_category_CB";
            Order_category_CB.Size = new Size(165, 31);
            Order_category_CB.TabIndex = 46;
            // 
            // Total_Items_Label
            // 
            Total_Items_Label.AutoSize = true;
            Total_Items_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_Items_Label.ForeColor = Color.WhiteSmoke;
            Total_Items_Label.Location = new Point(495, 423);
            Total_Items_Label.Name = "Total_Items_Label";
            Total_Items_Label.Size = new Size(125, 23);
            Total_Items_Label.TabIndex = 47;
            Total_Items_Label.Text = "Total Items:";
            // 
            // Total_Bill_Label
            // 
            Total_Bill_Label.AutoSize = true;
            Total_Bill_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_Bill_Label.ForeColor = Color.WhiteSmoke;
            Total_Bill_Label.Location = new Point(496, 487);
            Total_Bill_Label.Name = "Total_Bill_Label";
            Total_Bill_Label.Size = new Size(94, 23);
            Total_Bill_Label.TabIndex = 48;
            Total_Bill_Label.Text = "Total Bill:";
            // 
            // Payment_Label
            // 
            Payment_Label.AutoSize = true;
            Payment_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Payment_Label.ForeColor = Color.WhiteSmoke;
            Payment_Label.Location = new Point(495, 359);
            Payment_Label.Name = "Payment_Label";
            Payment_Label.Size = new Size(97, 23);
            Payment_Label.TabIndex = 50;
            Payment_Label.Text = "Payment:";
            // 
            // Payment_CB
            // 
            Payment_CB.BackColor = Color.FromArgb(111, 76, 68);
            Payment_CB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Payment_CB.ForeColor = Color.WhiteSmoke;
            Payment_CB.FormattingEnabled = true;
            Payment_CB.Items.AddRange(new object[] { "Card", "Cash", "Mobile Payment" });
            Payment_CB.Location = new Point(604, 351);
            Payment_CB.Name = "Payment_CB";
            Payment_CB.Size = new Size(165, 31);
            Payment_CB.TabIndex = 51;
            // 
            // Order_ID_Label
            // 
            Order_ID_Label.AutoSize = true;
            Order_ID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_ID_Label.ForeColor = Color.WhiteSmoke;
            Order_ID_Label.Location = new Point(496, 103);
            Order_ID_Label.Name = "Order_ID_Label";
            Order_ID_Label.Size = new Size(92, 23);
            Order_ID_Label.TabIndex = 52;
            Order_ID_Label.Text = "Order ID:";
            // 
            // Menu_panel
            // 
            Menu_panel.AutoScroll = true;
            Menu_panel.BackColor = Color.FromArgb(255, 233, 173);
            Menu_panel.Location = new Point(30, 129);
            Menu_panel.Name = "Menu_panel";
            Menu_panel.Size = new Size(454, 475);
            Menu_panel.TabIndex = 53;
            // 
            // OrderID_Label
            // 
            OrderID_Label.AutoSize = true;
            OrderID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderID_Label.ForeColor = Color.WhiteSmoke;
            OrderID_Label.Location = new Point(594, 103);
            OrderID_Label.Name = "OrderID_Label";
            OrderID_Label.Size = new Size(87, 23);
            OrderID_Label.TabIndex = 58;
            OrderID_Label.Text = "Order ID";
            // 
            // TotalBill_Label
            // 
            TotalBill_Label.AutoSize = true;
            TotalBill_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalBill_Label.ForeColor = Color.WhiteSmoke;
            TotalBill_Label.Location = new Point(596, 487);
            TotalBill_Label.Name = "TotalBill_Label";
            TotalBill_Label.Size = new Size(89, 23);
            TotalBill_Label.TabIndex = 57;
            TotalBill_Label.Text = "Total Bill";
            // 
            // TotalItems_Label
            // 
            TotalItems_Label.AutoSize = true;
            TotalItems_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalItems_Label.ForeColor = Color.WhiteSmoke;
            TotalItems_Label.Location = new Point(626, 423);
            TotalItems_Label.Name = "TotalItems_Label";
            TotalItems_Label.Size = new Size(120, 23);
            TotalItems_Label.TabIndex = 56;
            TotalItems_Label.Text = "Total Items";
            // 
            // ServerID_Label
            // 
            ServerID_Label.AutoSize = true;
            ServerID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ServerID_Label.ForeColor = Color.WhiteSmoke;
            ServerID_Label.Location = new Point(603, 231);
            ServerID_Label.Name = "ServerID_Label";
            ServerID_Label.Size = new Size(97, 23);
            ServerID_Label.TabIndex = 55;
            ServerID_Label.Text = "Server ID";
            // 
            // CustomerID_Label
            // 
            CustomerID_Label.AutoSize = true;
            CustomerID_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerID_Label.ForeColor = Color.WhiteSmoke;
            CustomerID_Label.Location = new Point(626, 167);
            CustomerID_Label.Name = "CustomerID_Label";
            CustomerID_Label.Size = new Size(126, 23);
            CustomerID_Label.TabIndex = 54;
            CustomerID_Label.Text = "Customer ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Pixelify Sans Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(51, 35, 31);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(192, 64, 0);
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.Font = new Font("Pixelify Sans Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(504, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 22);
            dateTimePicker1.TabIndex = 61;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(782, 614);
            Controls.Add(dateTimePicker1);
            Controls.Add(OrderID_Label);
            Controls.Add(TotalBill_Label);
            Controls.Add(TotalItems_Label);
            Controls.Add(ServerID_Label);
            Controls.Add(CustomerID_Label);
            Controls.Add(Menu_panel);
            Controls.Add(Order_ID_Label);
            Controls.Add(Payment_CB);
            Controls.Add(Payment_Label);
            Controls.Add(Total_Bill_Label);
            Controls.Add(Total_Items_Label);
            Controls.Add(Order_category_CB);
            Controls.Add(Order_Category_Label);
            Controls.Add(Server_ID_Label);
            Controls.Add(Customer_ID_L);
            Controls.Add(Done_button);
            Controls.Add(Customer_ID_Label);
            Controls.Add(Back_label_button);
            Controls.Add(Vintage_label);
            Controls.Add(Close_button_label);
            Controls.Add(Order_PB);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
            ((System.ComponentModel.ISupportInitialize)Order_PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Order_PB;
        private Label Back_label_button;
        private Label Vintage_label;
        private Label Close_button_label;
        private Label Customer_ID_Label;
        private Button Done_button;
        private Label Customer_ID_L;
        private Label Server_ID_Label;
        private Label Order_Category_Label;
        private ComboBox Order_category_CB;
        private Label Total_Items_Label;
        private Label Total_Bill_Label;
        private Label Payment_Label;
        private ComboBox Payment_CB;
        private Label Order_ID_Label;
        private Panel Menu_panel;
        private Label OrderID_Label;
        private Label TotalBill_Label;
        private Label TotalItems_Label;
        private Label ServerID_Label;
        private Label CustomerID_Label;
        private DateTimePicker dateTimePicker1;
    }
}