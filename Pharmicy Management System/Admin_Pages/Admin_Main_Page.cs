using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmicy_Management_System
{
    public partial class Admin_Main_Page : Form
    {
        public Admin_Main_Page()
        {
            InitializeComponent();
        }
        private void Btn_Facebook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk)==DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/mohammad.maaz.334");
            }      
        }

        private void Btn_Medicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Medicines Admin_Medi = new Admin_Medicines();
            Admin_Medi.Show();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        private void Admin_Main_Page_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            timer1.Enabled = true;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Main_Page Admin_Main = new Admin_Main_Page();
            Admin_Main.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Purchase All_Purchase_Frm = new All_Purchase();
            All_Purchase_Frm.Show();
        }
    }
}
