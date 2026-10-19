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
    public partial class CustomErrorMessageBox : Form
    {
        //Custom dialog result options
        public enum CustomDialogResult
        {
            None,
            Yes,
            No,
            OK
        }

        private void CustomErrorMessageBox_Load(object sender, EventArgs e) { }

        //Stores the user's selection
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CustomDialogResult Result = CustomDialogResult.None;

        //Constructor - initializes and shows the form
        public CustomErrorMessageBox()
        {
            InitializeComponent();
            this.Show();
        }

        // Defines which buttons to display
        public enum MessageBoxButtons
        {
            OK = 0,
            YesNO = 1
        };

        //Main method to display the custom message box
        public CustomDialogResult show(string msg, string title, MessageBoxButtons button)
         {
            //Hide if already visible (prevents duplicate instances)
            if (this.Visible)
            {
                 this.Hide();
            }

             Message_Title.Text = title;
             Message.Text = msg;

             //Configure buttons based on requested type
             Yes_button.Visible = (button == MessageBoxButtons.YesNO);
             No_button.Visible = (button == MessageBoxButtons.YesNO);
             Okay_button.Visible = (button == MessageBoxButtons.OK);

             //Button Click events
             Yes_button.Click += (s, e) => { this.DialogResult = DialogResult.Yes; };
             No_button.Click += (s, e) => { this.DialogResult = DialogResult.No; };
             Okay_button.Click += (s, e) => { this.DialogResult = DialogResult.OK; };

             this.ShowDialog();
            return Result;
        }

        //Button Handlers
        private void Close_button_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Okay_button_Click(object sender, EventArgs e)
        {
            Result = CustomDialogResult.OK; 
            this.Close();
        }

        private void No_button_Click(object sender, EventArgs e)
        {
            Result = CustomDialogResult.No; 
            this.Close();
        }

        private void Yes_button_Click(object sender, EventArgs e)
        {
            Result = CustomDialogResult.Yes; 
            this.Close();
        }

    }
}
