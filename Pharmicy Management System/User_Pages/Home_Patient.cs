using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This is For Round Form Lib
using System.Runtime.InteropServices;

namespace Pharmicy_Management_System
{
    public partial class Home_Patient : Form
    {
        //This is For Round Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        //End
        public Home_Patient()
        {
            InitializeComponent();
            //This is For Round Form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width , Height, 20, 20));
            //End

        }

        private void Btn_Medicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine_Search Medicine_Search_Frm = new Medicine_Search();
            Medicine_Search_Frm.Show();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading_Frm Loading_Frm = new Loading_Frm();
            Loading_Frm.Show();
        }

        private void Btn_Facebook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/mohammad.maaz.334");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_a_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formula_Search Formula_Search_Frm = new Formula_Search();
            Formula_Search_Frm.Show();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }

        private void Home_Patient_Load(object sender, EventArgs e)
        {
            //Loading Page Slow
            this.Opacity = 0;
            timer1.Enabled = true;
            //End
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Loading Page Slow
            this.Opacity += 0.07;
            //End
        }

        private void Btn_About_Us_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Us About_Us_Frm = new About_Us();
            About_Us_Frm.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            Pic_Pakistan.Width = 100;
            Pic_Pakistan.Height = 100;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Pic_Pakistan.Width = 60;
            Pic_Pakistan.Height = 49;
        }

        private void Btn_Drug_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drug_Search Drug_Search_Frm = new Drug_Search();
            Drug_Search_Frm.Show();
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Company_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company_Search Company_Search_Frm = new Company_Search();
            Company_Search_Frm.Show();
        }
    }
}
