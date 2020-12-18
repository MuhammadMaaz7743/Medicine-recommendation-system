using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pharmicy_Management_System
{
    public partial class Loading_Frm : Form
    {
        //For round Form
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

        int counter = 0;
        int len = 0;
        string txt;
        public Loading_Frm()
        {
            InitializeComponent();
            //For round Form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //END
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 5;
                if (rectangleShape2.Width >= 592)
                {
                    timer1.Stop();
                    this.Hide();
                    Login_Form Login_Form = new Login_Form();
                    Login_Form.Show();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        private void Loading_Frm_Load(object sender, EventArgs e)
        {

            this.Opacity = 0;
            timer2.Enabled = true;


            txt = label4.Text;
            len = txt.Length;
            label4.Text = "";
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                label4.Text = "";
            }

            else
            {

                label4.Text = txt.Substring(0, counter);

                if (label4.ForeColor == Color.Black)
                    label4.ForeColor = Color.Red;
                else
                    label4.ForeColor = Color.Black;
            }
        }
    }
}
