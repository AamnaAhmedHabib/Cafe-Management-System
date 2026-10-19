using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe
{
    public partial class Cashier_view : Form
    {
        public Cashier_view()
        {
            InitializeComponent();
        }

        private void Cashier_view_Load(object sender, EventArgs e)
        {
            Customer_LB.Parent = CafeIn_pic;
            Customer_LB.BackColor = Color.Transparent;

            Dashboard_LB.Parent = CafeIn_pic;
            Dashboard_LB.BackColor = Color.Transparent;
        }

        private void Close_button_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_button_label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Customer_LB_Click(object sender, EventArgs e)
        {
            Cashier_CRUD form = new Cashier_CRUD();
            form.SetActiveTab(1);
            form.Show();
            this.Hide();
        }

        private void Customer_LB_Hover(object sender, EventArgs e)
        {
            toolTip.Show("Click to View Customer Details!", Customer_LB);
        }

        private void Dashboard_LB_Click(object sender, EventArgs e)
        {
            Cashier_CRUD form = new Cashier_CRUD();
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
            Cashier_SignIn f = new Cashier_SignIn();
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
