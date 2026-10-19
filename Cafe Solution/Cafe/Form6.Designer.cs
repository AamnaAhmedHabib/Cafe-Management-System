namespace Cafe
{
    partial class Admin_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_CRUD));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            Vintage_label = new Label();
            Min_button_label = new Label();
            Close_button_label = new Label();
            Admin_TC = new TabControl();
            Dashboard = new TabPage();
            Weekly_Income_Number_label = new Label();
            Todays_Income_Number_label = new Label();
            Total_Customer_Number_label = new Label();
            Total_Users_Number_label = new Label();
            Weekly_income_L = new Label();
            Today_Income_L = new Label();
            No_Of_Customers_Label = new Label();
            No_Of_Users_Label = new Label();
            label1 = new Label();
            Customers = new PictureBox();
            Cashier = new PictureBox();
            Money_bag = new PictureBox();
            Money_bill = new PictureBox();
            Todays_Income_Label = new Label();
            Weekly_Income_Label = new Label();
            Note3 = new PictureBox();
            Note4 = new PictureBox();
            Total_Customers_Label = new Label();
            Note2 = new PictureBox();
            Total_Cashiers_Label = new Label();
            Dashboard_Label = new Label();
            Note1 = new PictureBox();
            Data_of_Users_TP = new TabPage();
            Search_Filter_CB = new ComboBox();
            Filter_Label = new Label();
            SearchBox = new TextBox();
            Search_button = new Button();
            Delete_button = new Button();
            Update_button = new Button();
            Add_button = new Button();
            Data_Users_DGV = new DataGridView();
            Data_users_label = new Label();
            Customers_TP = new TabPage();
            Filter_CB2 = new ComboBox();
            Filter_label2 = new Label();
            SearchBox2 = new TextBox();
            Search_button2 = new Button();
            Data_Customers_DGV = new DataGridView();
            Data_customers_label = new Label();
            pictureBox1 = new PictureBox();
            Back_label_button = new Label();
            Admin_TC.SuspendLayout();
            Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Customers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cashier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Money_bag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Money_bill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Note3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Note4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Note2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Note1).BeginInit();
            Data_of_Users_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Users_DGV).BeginInit();
            Customers_TP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Customers_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Vintage_label
            // 
            Vintage_label.AutoSize = true;
            Vintage_label.Font = new Font("Pixelify Sans SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vintage_label.ForeColor = Color.White;
            Vintage_label.Location = new Point(48, 18);
            Vintage_label.Name = "Vintage_label";
            Vintage_label.Size = new Size(231, 20);
            Vintage_label.TabIndex = 15;
            Vintage_label.Text = "Vintage Cafe - Admin Portal";
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
            Min_button_label.TabIndex = 14;
            Min_button_label.Text = "_";
            Min_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Min_button_label.Click += Min_button_label_Click;
            // 
            // Close_button_label
            // 
            Close_button_label.AutoSize = true;
            Close_button_label.Cursor = Cursors.PanNW;
            Close_button_label.FlatStyle = FlatStyle.Flat;
            Close_button_label.Font = new Font("Pixelify Sans SemBd", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close_button_label.ForeColor = Color.White;
            Close_button_label.Location = new Point(747, 13);
            Close_button_label.Name = "Close_button_label";
            Close_button_label.Size = new Size(30, 31);
            Close_button_label.TabIndex = 13;
            Close_button_label.Text = "x";
            Close_button_label.TextAlign = ContentAlignment.MiddleCenter;
            Close_button_label.Click += Close_button_label_Click;
            // 
            // Admin_TC
            // 
            Admin_TC.Controls.Add(Dashboard);
            Admin_TC.Controls.Add(Data_of_Users_TP);
            Admin_TC.Controls.Add(Customers_TP);
            Admin_TC.Cursor = Cursors.PanNW;
            Admin_TC.Font = new Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_TC.ItemSize = new Size(0, 1);
            Admin_TC.Location = new Point(13, 45);
            Admin_TC.Name = "Admin_TC";
            Admin_TC.SelectedIndex = 0;
            Admin_TC.Size = new Size(764, 562);
            Admin_TC.TabIndex = 17;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(51, 35, 31);
            Dashboard.Controls.Add(Weekly_Income_Number_label);
            Dashboard.Controls.Add(Todays_Income_Number_label);
            Dashboard.Controls.Add(Total_Customer_Number_label);
            Dashboard.Controls.Add(Total_Users_Number_label);
            Dashboard.Controls.Add(Weekly_income_L);
            Dashboard.Controls.Add(Today_Income_L);
            Dashboard.Controls.Add(No_Of_Customers_Label);
            Dashboard.Controls.Add(No_Of_Users_Label);
            Dashboard.Controls.Add(label1);
            Dashboard.Controls.Add(Customers);
            Dashboard.Controls.Add(Cashier);
            Dashboard.Controls.Add(Money_bag);
            Dashboard.Controls.Add(Money_bill);
            Dashboard.Controls.Add(Todays_Income_Label);
            Dashboard.Controls.Add(Weekly_Income_Label);
            Dashboard.Controls.Add(Note3);
            Dashboard.Controls.Add(Note4);
            Dashboard.Controls.Add(Total_Customers_Label);
            Dashboard.Controls.Add(Note2);
            Dashboard.Controls.Add(Total_Cashiers_Label);
            Dashboard.Controls.Add(Dashboard_Label);
            Dashboard.Controls.Add(Note1);
            Dashboard.Location = new Point(4, 5);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(3);
            Dashboard.Size = new Size(756, 553);
            Dashboard.TabIndex = 0;
            Dashboard.Text = "Dashboard";
            // 
            // Weekly_Income_Number_label
            // 
            Weekly_Income_Number_label.AutoSize = true;
            Weekly_Income_Number_label.BackColor = Color.FromArgb(255, 233, 173);
            Weekly_Income_Number_label.Cursor = Cursors.PanNW;
            Weekly_Income_Number_label.Font = new Font("Pixelify Sans SemiBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Weekly_Income_Number_label.ForeColor = Color.Black;
            Weekly_Income_Number_label.Location = new Point(545, 398);
            Weekly_Income_Number_label.Name = "Weekly_Income_Number_label";
            Weekly_Income_Number_label.Size = new Size(157, 45);
            Weekly_Income_Number_label.TabIndex = 28;
            Weekly_Income_Number_label.Text = "Number";
            Weekly_Income_Number_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Todays_Income_Number_label
            // 
            Todays_Income_Number_label.AutoSize = true;
            Todays_Income_Number_label.BackColor = Color.FromArgb(255, 233, 173);
            Todays_Income_Number_label.Cursor = Cursors.PanNW;
            Todays_Income_Number_label.Font = new Font("Pixelify Sans SemiBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Todays_Income_Number_label.ForeColor = Color.Black;
            Todays_Income_Number_label.Location = new Point(174, 398);
            Todays_Income_Number_label.Name = "Todays_Income_Number_label";
            Todays_Income_Number_label.Size = new Size(157, 45);
            Todays_Income_Number_label.TabIndex = 27;
            Todays_Income_Number_label.Text = "Number";
            Todays_Income_Number_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Total_Customer_Number_label
            // 
            Total_Customer_Number_label.AutoSize = true;
            Total_Customer_Number_label.BackColor = Color.FromArgb(255, 233, 173);
            Total_Customer_Number_label.Cursor = Cursors.PanNW;
            Total_Customer_Number_label.Font = new Font("Pixelify Sans SemiBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_Customer_Number_label.ForeColor = Color.Black;
            Total_Customer_Number_label.Location = new Point(545, 177);
            Total_Customer_Number_label.Name = "Total_Customer_Number_label";
            Total_Customer_Number_label.Size = new Size(157, 45);
            Total_Customer_Number_label.TabIndex = 26;
            Total_Customer_Number_label.Text = "Number";
            Total_Customer_Number_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Total_Users_Number_label
            // 
            Total_Users_Number_label.AutoSize = true;
            Total_Users_Number_label.BackColor = Color.FromArgb(255, 233, 173);
            Total_Users_Number_label.Cursor = Cursors.PanNW;
            Total_Users_Number_label.Font = new Font("Pixelify Sans SemiBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_Users_Number_label.ForeColor = Color.Black;
            Total_Users_Number_label.Location = new Point(174, 177);
            Total_Users_Number_label.Name = "Total_Users_Number_label";
            Total_Users_Number_label.Size = new Size(157, 45);
            Total_Users_Number_label.TabIndex = 25;
            Total_Users_Number_label.Text = "Number";
            Total_Users_Number_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Weekly_income_L
            // 
            Weekly_income_L.AutoSize = true;
            Weekly_income_L.BackColor = Color.FromArgb(255, 233, 173);
            Weekly_income_L.Cursor = Cursors.PanNW;
            Weekly_income_L.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Weekly_income_L.ForeColor = Color.Black;
            Weekly_income_L.Location = new Point(499, 329);
            Weekly_income_L.Name = "Weekly_income_L";
            Weekly_income_L.Size = new Size(214, 33);
            Weekly_income_L.TabIndex = 24;
            Weekly_income_L.Text = "Weekly Income";
            Weekly_income_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Today_Income_L
            // 
            Today_Income_L.AutoSize = true;
            Today_Income_L.BackColor = Color.FromArgb(255, 233, 173);
            Today_Income_L.Cursor = Cursors.PanNW;
            Today_Income_L.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Today_Income_L.ForeColor = Color.Black;
            Today_Income_L.Location = new Point(114, 329);
            Today_Income_L.Name = "Today_Income_L";
            Today_Income_L.Size = new Size(227, 33);
            Today_Income_L.TabIndex = 23;
            Today_Income_L.Text = "Today's Income";
            Today_Income_L.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // No_Of_Customers_Label
            // 
            No_Of_Customers_Label.AutoSize = true;
            No_Of_Customers_Label.BackColor = Color.FromArgb(255, 233, 173);
            No_Of_Customers_Label.Cursor = Cursors.PanNW;
            No_Of_Customers_Label.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            No_Of_Customers_Label.ForeColor = Color.Black;
            No_Of_Customers_Label.Location = new Point(457, 107);
            No_Of_Customers_Label.Name = "No_Of_Customers_Label";
            No_Of_Customers_Label.Size = new Size(256, 33);
            No_Of_Customers_Label.TabIndex = 22;
            No_Of_Customers_Label.Text = "Total Customers";
            No_Of_Customers_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // No_Of_Users_Label
            // 
            No_Of_Users_Label.AutoSize = true;
            No_Of_Users_Label.BackColor = Color.FromArgb(255, 233, 173);
            No_Of_Users_Label.Cursor = Cursors.PanNW;
            No_Of_Users_Label.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            No_Of_Users_Label.ForeColor = Color.Black;
            No_Of_Users_Label.Location = new Point(161, 107);
            No_Of_Users_Label.Name = "No_Of_Users_Label";
            No_Of_Users_Label.Size = new Size(180, 33);
            No_Of_Users_Label.TabIndex = 21;
            No_Of_Users_Label.Text = "Total Users";
            No_Of_Users_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.PanNW;
            label1.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(171, 33);
            label1.TabIndex = 20;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Customers
            // 
            Customers.BackColor = Color.FromArgb(255, 233, 173);
            Customers.BackgroundImage = (Image)resources.GetObject("Customers.BackgroundImage");
            Customers.BackgroundImageLayout = ImageLayout.Stretch;
            Customers.Location = new Point(430, 174);
            Customers.Name = "Customers";
            Customers.Size = new Size(100, 50);
            Customers.TabIndex = 19;
            Customers.TabStop = false;
            // 
            // Cashier
            // 
            Cashier.BackColor = Color.FromArgb(255, 233, 173);
            Cashier.BackgroundImage = (Image)resources.GetObject("Cashier.BackgroundImage");
            Cashier.BackgroundImageLayout = ImageLayout.Stretch;
            Cashier.Location = new Point(61, 151);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(100, 96);
            Cashier.TabIndex = 18;
            Cashier.TabStop = false;
            // 
            // Money_bag
            // 
            Money_bag.BackColor = Color.FromArgb(255, 233, 173);
            Money_bag.BackgroundImage = (Image)resources.GetObject("Money_bag.BackgroundImage");
            Money_bag.BackgroundImageLayout = ImageLayout.Stretch;
            Money_bag.Location = new Point(430, 371);
            Money_bag.Name = "Money_bag";
            Money_bag.Size = new Size(100, 100);
            Money_bag.TabIndex = 17;
            Money_bag.TabStop = false;
            // 
            // Money_bill
            // 
            Money_bill.BackColor = Color.FromArgb(255, 233, 173);
            Money_bill.BackgroundImage = (Image)resources.GetObject("Money_bill.BackgroundImage");
            Money_bill.BackgroundImageLayout = ImageLayout.Stretch;
            Money_bill.Location = new Point(61, 396);
            Money_bill.Name = "Money_bill";
            Money_bill.Size = new Size(100, 50);
            Money_bill.TabIndex = 16;
            Money_bill.TabStop = false;
            // 
            // Todays_Income_Label
            // 
            Todays_Income_Label.AutoSize = true;
            Todays_Income_Label.BackColor = Color.FromArgb(255, 233, 173);
            Todays_Income_Label.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Todays_Income_Label.Location = new Point(44, 329);
            Todays_Income_Label.Name = "Todays_Income_Label";
            Todays_Income_Label.Size = new Size(0, 29);
            Todays_Income_Label.TabIndex = 11;
            // 
            // Weekly_Income_Label
            // 
            Weekly_Income_Label.AutoSize = true;
            Weekly_Income_Label.BackColor = Color.FromArgb(255, 233, 173);
            Weekly_Income_Label.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Weekly_Income_Label.Location = new Point(415, 329);
            Weekly_Income_Label.Name = "Weekly_Income_Label";
            Weekly_Income_Label.Size = new Size(0, 29);
            Weekly_Income_Label.TabIndex = 12;
            // 
            // Note3
            // 
            Note3.BackColor = Color.FromArgb(51, 35, 31);
            Note3.BackgroundImage = (Image)resources.GetObject("Note3.BackgroundImage");
            Note3.BackgroundImageLayout = ImageLayout.Stretch;
            Note3.Location = new Point(414, 292);
            Note3.Name = "Note3";
            Note3.Size = new Size(301, 199);
            Note3.TabIndex = 15;
            Note3.TabStop = false;
            // 
            // Note4
            // 
            Note4.BackColor = Color.FromArgb(51, 35, 31);
            Note4.BackgroundImage = (Image)resources.GetObject("Note4.BackgroundImage");
            Note4.BackgroundImageLayout = ImageLayout.Stretch;
            Note4.Location = new Point(44, 292);
            Note4.Name = "Note4";
            Note4.Size = new Size(301, 199);
            Note4.TabIndex = 14;
            Note4.TabStop = false;
            // 
            // Total_Customers_Label
            // 
            Total_Customers_Label.AutoSize = true;
            Total_Customers_Label.BackColor = Color.FromArgb(255, 233, 173);
            Total_Customers_Label.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_Customers_Label.Location = new Point(415, 107);
            Total_Customers_Label.Name = "Total_Customers_Label";
            Total_Customers_Label.Size = new Size(0, 29);
            Total_Customers_Label.TabIndex = 10;
            // 
            // Note2
            // 
            Note2.BackColor = Color.FromArgb(51, 35, 31);
            Note2.BackgroundImage = (Image)resources.GetObject("Note2.BackgroundImage");
            Note2.BackgroundImageLayout = ImageLayout.Stretch;
            Note2.Location = new Point(414, 70);
            Note2.Name = "Note2";
            Note2.Size = new Size(301, 199);
            Note2.TabIndex = 13;
            Note2.TabStop = false;
            // 
            // Total_Cashiers_Label
            // 
            Total_Cashiers_Label.AutoSize = true;
            Total_Cashiers_Label.BackColor = Color.FromArgb(255, 233, 173);
            Total_Cashiers_Label.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_Cashiers_Label.Location = new Point(45, 107);
            Total_Cashiers_Label.Name = "Total_Cashiers_Label";
            Total_Cashiers_Label.Size = new Size(0, 29);
            Total_Cashiers_Label.TabIndex = 9;
            // 
            // Dashboard_Label
            // 
            Dashboard_Label.AutoSize = true;
            Dashboard_Label.Cursor = Cursors.PanNW;
            Dashboard_Label.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard_Label.ForeColor = Color.WhiteSmoke;
            Dashboard_Label.Location = new Point(23, 18);
            Dashboard_Label.Name = "Dashboard_Label";
            Dashboard_Label.Size = new Size(0, 33);
            Dashboard_Label.TabIndex = 4;
            Dashboard_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Note1
            // 
            Note1.BackColor = Color.FromArgb(51, 35, 31);
            Note1.BackgroundImage = (Image)resources.GetObject("Note1.BackgroundImage");
            Note1.BackgroundImageLayout = ImageLayout.Stretch;
            Note1.Location = new Point(44, 70);
            Note1.Name = "Note1";
            Note1.Size = new Size(301, 199);
            Note1.TabIndex = 0;
            Note1.TabStop = false;
            // 
            // Data_of_Users_TP
            // 
            Data_of_Users_TP.BackColor = Color.FromArgb(51, 35, 31);
            Data_of_Users_TP.Controls.Add(Search_Filter_CB);
            Data_of_Users_TP.Controls.Add(Filter_Label);
            Data_of_Users_TP.Controls.Add(SearchBox);
            Data_of_Users_TP.Controls.Add(Search_button);
            Data_of_Users_TP.Controls.Add(Delete_button);
            Data_of_Users_TP.Controls.Add(Update_button);
            Data_of_Users_TP.Controls.Add(Add_button);
            Data_of_Users_TP.Controls.Add(Data_Users_DGV);
            Data_of_Users_TP.Controls.Add(Data_users_label);
            Data_of_Users_TP.Location = new Point(4, 5);
            Data_of_Users_TP.Name = "Data_of_Users_TP";
            Data_of_Users_TP.Padding = new Padding(3);
            Data_of_Users_TP.Size = new Size(756, 553);
            Data_of_Users_TP.TabIndex = 1;
            Data_of_Users_TP.Text = "Users";
            // 
            // Search_Filter_CB
            // 
            Search_Filter_CB.BackColor = Color.FromArgb(111, 76, 68);
            Search_Filter_CB.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_Filter_CB.ForeColor = Color.WhiteSmoke;
            Search_Filter_CB.FormattingEnabled = true;
            Search_Filter_CB.Location = new Point(115, 88);
            Search_Filter_CB.Name = "Search_Filter_CB";
            Search_Filter_CB.Size = new Size(202, 31);
            Search_Filter_CB.TabIndex = 31;
            Search_Filter_CB.SelectedIndexChanged += Search_Filter_CB_SelectedIndexChanged;
            // 
            // Filter_Label
            // 
            Filter_Label.AutoSize = true;
            Filter_Label.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Filter_Label.ForeColor = Color.WhiteSmoke;
            Filter_Label.Location = new Point(30, 92);
            Filter_Label.Name = "Filter_Label";
            Filter_Label.Size = new Size(69, 23);
            Filter_Label.TabIndex = 30;
            Filter_Label.Text = "Filter:";
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.FromArgb(111, 76, 68);
            SearchBox.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox.ForeColor = Color.WhiteSmoke;
            SearchBox.Location = new Point(464, 88);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(202, 30);
            SearchBox.TabIndex = 29;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // Search_button
            // 
            Search_button.BackColor = Color.FromArgb(51, 35, 31);
            Search_button.BackgroundImage = (Image)resources.GetObject("Search_button.BackgroundImage");
            Search_button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_button.Cursor = Cursors.PanNW;
            Search_button.FlatAppearance.BorderColor = Color.FromArgb(51, 35, 31);
            Search_button.FlatAppearance.BorderSize = 0;
            Search_button.FlatStyle = FlatStyle.Popup;
            Search_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search_button.ForeColor = Color.WhiteSmoke;
            Search_button.Location = new Point(682, 84);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(44, 39);
            Search_button.TabIndex = 28;
            Search_button.UseVisualStyleBackColor = false;
            // 
            // Delete_button
            // 
            Delete_button.BackColor = Color.FromArgb(51, 35, 31);
            Delete_button.BackgroundImage = (Image)resources.GetObject("Delete_button.BackgroundImage");
            Delete_button.BackgroundImageLayout = ImageLayout.Stretch;
            Delete_button.Cursor = Cursors.PanNW;
            Delete_button.FlatStyle = FlatStyle.Popup;
            Delete_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_button.ForeColor = Color.WhiteSmoke;
            Delete_button.Location = new Point(682, 13);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(44, 39);
            Delete_button.TabIndex = 27;
            Delete_button.UseVisualStyleBackColor = false;
            Delete_button.Click += Delete_button_Click;
            // 
            // Update_button
            // 
            Update_button.BackColor = Color.FromArgb(51, 35, 31);
            Update_button.BackgroundImage = (Image)resources.GetObject("Update_button.BackgroundImage");
            Update_button.BackgroundImageLayout = ImageLayout.Stretch;
            Update_button.Cursor = Cursors.PanNW;
            Update_button.FlatStyle = FlatStyle.Popup;
            Update_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_button.ForeColor = Color.WhiteSmoke;
            Update_button.Location = new Point(588, 13);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(44, 39);
            Update_button.TabIndex = 26;
            Update_button.UseVisualStyleBackColor = false;
            Update_button.Click += Update_button_Click;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.FromArgb(51, 35, 31);
            Add_button.BackgroundImage = (Image)resources.GetObject("Add_button.BackgroundImage");
            Add_button.BackgroundImageLayout = ImageLayout.Stretch;
            Add_button.Cursor = Cursors.PanNW;
            Add_button.FlatStyle = FlatStyle.Popup;
            Add_button.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_button.ForeColor = Color.WhiteSmoke;
            Add_button.Location = new Point(494, 13);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(44, 39);
            Add_button.TabIndex = 25;
            Add_button.UseVisualStyleBackColor = false;
            Add_button.Click += Add_button_Click_1;
            // 
            // Data_Users_DGV
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 35, 31);
            dataGridViewCellStyle1.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            Data_Users_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Data_Users_DGV.BackgroundColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(200, 77, 16);
            dataGridViewCellStyle2.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Data_Users_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Data_Users_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle3.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Data_Users_DGV.DefaultCellStyle = dataGridViewCellStyle3;
            Data_Users_DGV.GridColor = Color.Black;
            Data_Users_DGV.Location = new Point(31, 129);
            Data_Users_DGV.Name = "Data_Users_DGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle4.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Data_Users_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle5.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            Data_Users_DGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            Data_Users_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_Users_DGV.Size = new Size(695, 377);
            Data_Users_DGV.TabIndex = 6;
            // 
            // Data_users_label
            // 
            Data_users_label.AutoSize = true;
            Data_users_label.Cursor = Cursors.PanNW;
            Data_users_label.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Data_users_label.ForeColor = Color.WhiteSmoke;
            Data_users_label.Location = new Point(23, 18);
            Data_users_label.Name = "Data_users_label";
            Data_users_label.Size = new Size(217, 33);
            Data_users_label.TabIndex = 5;
            Data_users_label.Text = "Data Of Users";
            Data_users_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Customers_TP
            // 
            Customers_TP.BackColor = Color.FromArgb(51, 35, 31);
            Customers_TP.Controls.Add(Filter_CB2);
            Customers_TP.Controls.Add(Filter_label2);
            Customers_TP.Controls.Add(SearchBox2);
            Customers_TP.Controls.Add(Search_button2);
            Customers_TP.Controls.Add(Data_Customers_DGV);
            Customers_TP.Controls.Add(Data_customers_label);
            Customers_TP.Location = new Point(4, 5);
            Customers_TP.Name = "Customers_TP";
            Customers_TP.Padding = new Padding(3);
            Customers_TP.Size = new Size(756, 553);
            Customers_TP.TabIndex = 3;
            Customers_TP.Text = "Customers";
            // 
            // Filter_CB2
            // 
            Filter_CB2.BackColor = Color.FromArgb(111, 76, 68);
            Filter_CB2.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Filter_CB2.ForeColor = Color.WhiteSmoke;
            Filter_CB2.FormattingEnabled = true;
            Filter_CB2.Location = new Point(115, 88);
            Filter_CB2.Name = "Filter_CB2";
            Filter_CB2.Size = new Size(202, 31);
            Filter_CB2.TabIndex = 34;
            Filter_CB2.SelectedIndexChanged += Filter_CB2_SelectedIndexChanged;
            // 
            // Filter_label2
            // 
            Filter_label2.AutoSize = true;
            Filter_label2.Font = new Font("Pixelify Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Filter_label2.ForeColor = Color.WhiteSmoke;
            Filter_label2.Location = new Point(30, 92);
            Filter_label2.Name = "Filter_label2";
            Filter_label2.Size = new Size(69, 23);
            Filter_label2.TabIndex = 33;
            Filter_label2.Text = "Filter:";
            // 
            // SearchBox2
            // 
            SearchBox2.BackColor = Color.FromArgb(111, 76, 68);
            SearchBox2.Font = new Font("Pixelify Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox2.ForeColor = Color.WhiteSmoke;
            SearchBox2.Location = new Point(464, 88);
            SearchBox2.Name = "SearchBox2";
            SearchBox2.Size = new Size(202, 30);
            SearchBox2.TabIndex = 32;
            SearchBox2.TextChanged += SearchBox2_TextChanged;
            // 
            // Search_button2
            // 
            Search_button2.BackColor = Color.FromArgb(51, 35, 31);
            Search_button2.BackgroundImage = (Image)resources.GetObject("Search_button2.BackgroundImage");
            Search_button2.BackgroundImageLayout = ImageLayout.Stretch;
            Search_button2.Cursor = Cursors.PanNW;
            Search_button2.FlatStyle = FlatStyle.Popup;
            Search_button2.Font = new Font("Pixelify Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search_button2.ForeColor = Color.WhiteSmoke;
            Search_button2.Location = new Point(682, 84);
            Search_button2.Name = "Search_button2";
            Search_button2.Size = new Size(44, 39);
            Search_button2.TabIndex = 31;
            Search_button2.UseVisualStyleBackColor = false;
            // 
            // Data_Customers_DGV
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(51, 35, 31);
            dataGridViewCellStyle6.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            Data_Customers_DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            Data_Customers_DGV.BackgroundColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(200, 77, 16);
            dataGridViewCellStyle7.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(180, 53, 29);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            Data_Customers_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            Data_Customers_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle8.Font = new Font("Pixelify Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            Data_Customers_DGV.DefaultCellStyle = dataGridViewCellStyle8;
            Data_Customers_DGV.GridColor = Color.Black;
            Data_Customers_DGV.Location = new Point(31, 129);
            Data_Customers_DGV.Name = "Data_Customers_DGV";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle9.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            Data_Customers_DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(111, 76, 68);
            dataGridViewCellStyle10.Font = new Font("Pixelify Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(180, 59, 23);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            Data_Customers_DGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            Data_Customers_DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Data_Customers_DGV.Size = new Size(695, 377);
            Data_Customers_DGV.TabIndex = 30;
            // 
            // Data_customers_label
            // 
            Data_customers_label.AutoSize = true;
            Data_customers_label.Cursor = Cursors.PanNW;
            Data_customers_label.Font = new Font("Pixelify Sans SemBd", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Data_customers_label.ForeColor = Color.WhiteSmoke;
            Data_customers_label.Location = new Point(23, 18);
            Data_customers_label.Name = "Data_customers_label";
            Data_customers_label.Size = new Size(293, 33);
            Data_customers_label.TabIndex = 29;
            Data_customers_label.Text = "Data Of Customers";
            Data_customers_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(13, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(764, 6);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Back_label_button
            // 
            Back_label_button.Cursor = Cursors.PanNW;
            Back_label_button.FlatStyle = FlatStyle.Flat;
            Back_label_button.Font = new Font("Pixelify Sans SemBd", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back_label_button.ForeColor = Color.White;
            Back_label_button.Location = new Point(13, 16);
            Back_label_button.Name = "Back_label_button";
            Back_label_button.Size = new Size(30, 30);
            Back_label_button.TabIndex = 18;
            Back_label_button.Text = "<";
            Back_label_button.TextAlign = ContentAlignment.MiddleCenter;
            Back_label_button.Click += Back_label_button_Click;
            // 
            // Admin_CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 35, 31);
            ClientSize = new Size(790, 620);
            Controls.Add(pictureBox1);
            Controls.Add(Back_label_button);
            Controls.Add(Admin_TC);
            Controls.Add(Vintage_label);
            Controls.Add(Min_button_label);
            Controls.Add(Close_button_label);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_CRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_CRUD";
            Load += Admin_CRUD_Load;
            Admin_TC.ResumeLayout(false);
            Dashboard.ResumeLayout(false);
            Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Customers).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cashier).EndInit();
            ((System.ComponentModel.ISupportInitialize)Money_bag).EndInit();
            ((System.ComponentModel.ISupportInitialize)Money_bill).EndInit();
            ((System.ComponentModel.ISupportInitialize)Note3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Note4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Note2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Note1).EndInit();
            Data_of_Users_TP.ResumeLayout(false);
            Data_of_Users_TP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Users_DGV).EndInit();
            Customers_TP.ResumeLayout(false);
            Customers_TP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Customers_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Vintage_label;
        private Label Min_button_label;
        private Label Close_button_label;
        private TabControl Admin_TC;
        private TabPage Data_of_Users_TP;
        private TabPage Customers_TP;
        private Label Data_users_label;
        private DataGridView Data_Users_DGV;
        private Button Search_button;
        private Button Delete_button;
        private Button Update_button;
        private Button Add_button;
        private Label Back_label_button;
        private Button Search_button2;
        private DataGridView Data_Customers_DGV;
        private Label Data_customers_label;
        private TabPage Dashboard;
        private PictureBox Customers;
        private PictureBox Cashier;
        private PictureBox Money_bag;
        private PictureBox Money_bill;
        private Label Todays_Income_Label;
        private Label Weekly_Income_Label;
        private PictureBox Note3;
        private PictureBox Note4;
        private Label Total_Customers_Label;
        private PictureBox Note2;
        private Label Total_Cashiers_Label;
        private Label Dashboard_Label;
        private PictureBox Note1;
        private Label No_Of_Users_Label;
        private Label label1;
        private Label No_Of_Customers_Label;
        private Label Weekly_income_L;
        private Label Today_Income_L;
        private PictureBox pictureBox1;
        private ComboBox Search_Filter_CB;
        private Label Filter_Label;
        private ComboBox Filter_CB2;
        private Label Filter_label2;
        private TextBox SearchBox2;
        private Label Total_Users_Number_label;
        private Label Total_Customer_Number_label;
        private Label Weekly_Income_Number_label;
        private Label Todays_Income_Number_label;
        private TextBox SearchBox;
    }
}