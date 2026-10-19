namespace Cafe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Welcome_label.Parent = Cafe_pic;
            Welcome_label.BackColor = Color.FromArgb(153, 51, 35, 31);

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

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Admin_SignIn f2 = new Admin_SignIn();
            f2.Show();
            this.Hide();

        }

        private void Cashier_button_Click(object sender, EventArgs e)
        {
            Cashier_SignIn f3 = new Cashier_SignIn();
            f3.Show();
            this.Hide();
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }
    }

}
