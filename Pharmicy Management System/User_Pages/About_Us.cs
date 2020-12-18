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
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        private void About_Us_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;

            ////For Mouse Cursor Image
            //Bitmap bmp = new Bitmap(new Bitmap(@"C:\Users\MuhammadMaaz\Documents\Visual Studio 2015\Projects\Pharmicy Management System\Images\Benefits-of-Mouse-Cursors-2.png"),48,48);
            //this.Cursor = new Cursor(bmp.GetHicon());
        }

        private void ovalShape1_MouseHover(object sender, EventArgs e)
        {
            OvalShape_Maaz.Width = 100;
            OvalShape_Maaz.Height = 100;
        }

        private void ovalShape1_MouseLeave(object sender, EventArgs e)
        {
            OvalShape_Maaz.Width = 72;
            OvalShape_Maaz.Height = 75;
        }

        private void ovalShape2_MouseHover(object sender, EventArgs e)
        {
            OvalShape_Moazzam.Width = 100;
            OvalShape_Moazzam.Height = 100;
        }

        private void ovalShape2_MouseLeave(object sender, EventArgs e)
        {
            OvalShape_Moazzam.Width = 72;
            OvalShape_Moazzam.Height = 75;
        }

        private void ovalShape3_MouseHover(object sender, EventArgs e)
        {
            OvalShape_Ben.Width = 100;
            OvalShape_Ben.Height = 100;
        }

        private void ovalShape3_MouseLeave(object sender, EventArgs e)
        {
            OvalShape_Ben.Width = 72;
            OvalShape_Ben.Height = 75;
        }

        private void Btn_Medicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine_Search Medicine_Search_Frm = new Medicine_Search();
            Medicine_Search_Frm.Show();
        }

        private void Btn_Drug_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drug_Search Drug_Search_Frm = new Drug_Search();
            Drug_Search_Frm.Show();
        }

        private void Btn_Formula_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formula_Search Formula_Search_Frm = new Formula_Search();
            Formula_Search_Frm.Show();
        }

        private void Btn_Company_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company_Search Company_Search_Frm = new Company_Search();
            Company_Search_Frm.Show();
        }

        private void Btn_About_us_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Us About_Us_Frm = new About_Us();
            About_Us_Frm.Show();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading_Frm Loading_Frm = new Loading_Frm();
            Loading_Frm.Show();
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maaz_Fb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/mohammad.maaz.334");
            }
        }

        private void Btn_Maaz_Pin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Pinterest", "pinterest Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.pinterest.com/");
            }
        }

        private void Btn_Maaz_Twi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Twitter", "Twitter Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://twitter.com/login?lang=en");
            }
        }

        private void Btn_Moaz_Fb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/moazzam.waseem");
            }
        }

        private void Btn_Moaz_Twi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Twitter", "Twitter Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://twitter.com/login?lang=en");
            }
        }

        private void Btn_Ben_Fb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/benyameen.ashraf");
            }
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }
    }
}
