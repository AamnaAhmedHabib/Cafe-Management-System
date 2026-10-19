using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Admin_view : Form
    {

        public Admin_view()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        //Main Functioning Buttons
        private void Close_button_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_button_label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Admin_view_Load(object sender, EventArgs e)
        {
            Customer_LB.Parent = CafeIn_pic;
            Customer_LB.BackColor = Color.Transparent;

            Add_Cashier_LB.Parent = CafeIn_pic;
            Add_Cashier_LB.BackColor = Color.Transparent;

            Add_Products_LB.Parent = CafeIn_pic;
            Add_Products_LB.BackColor = Color.Transparent;

            Dashboard_LB.Parent = CafeIn_pic;
            Dashboard_LB.BackColor = Color.Transparent;
        }

        private void Customer_LB_Click(object sender, EventArgs e)
        {
            Admin_CRUD form = new Admin_CRUD();
            form.SetActiveTab(2);
            form.Show();
            this.Hide();
        }

        private void Customer_LB_Hover(object sender, EventArgs e)
        {
            toolTip.Show("Click to View Customer Details!", Customer_LB);

        }

        private void Add_Products_LB_Click(object sender, EventArgs e)
        {
            Add_Products_Menu form = new Add_Products_Menu();
            form.Show();
            this.Hide();

        }

        private void Add_Products_LB_Hover(object sender, EventArgs e)
        {
            toolTip.Show("Click to Add Products!", Add_Products_LB);
        }

        private void Add_Cashier_LB_Click(object sender, EventArgs e)
        {
            Admin_CRUD form = new Admin_CRUD();
            form.SetActiveTab(1);
            form.Show();
            this.Hide();
        }

        private void Add_Cashier_LB_Hover(object sender, EventArgs e)
        {
            toolTip.Show("Click to Add Cashier!", Add_Cashier_LB);
        }

        private void Dashboard_LB_Click(object sender, EventArgs e)
        {
            Admin_CRUD form = new Admin_CRUD();
            form.SetActiveTab(0);
            form.Show();
            this.Hide();
        }

        private void Dashboard_LB_Hover(object sender, EventArgs e)
        {
            toolTip.Show("Click to View Dashboard!", Dashboard_LB);

        }
        private void Logout_rug_Click(object sender, EventArgs e)
        {
            Admin_SignIn f = new Admin_SignIn();
            f.Show();
            this.Close();

        }

        private void Logout_rug_Hover(object sender, EventArgs e)
        {
            toolTip.Show("Click to Logout!", Logout_rug);
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();

        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
