using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Pharmicy_Management_System
{
    public partial class Login_Form : Form
    {
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
        public Login_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

            this.Opacity = 0;

            timer1.Enabled = true;
            //textBox1.BackColor = Color.Transparent;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Admin_Login Where User_Name='" + Txt_Name.Text + "' and Password ='" + Txt_Pass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Admin_Main_Page main = new Admin_Main_Page();
                main.Show();
            }
            else
            {
                //MessageBox.Show("Please Check Your UserName & Password");
                User_Name_Password User_Name_Password_frm = new User_Name_Password();
                User_Name_Password_frm.Show();
                con.Close();
                Txt_Name.Clear();
                Txt_Pass.Clear();
               
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Txt_Name.Text == "Enter Your User-Name")
            {
                Txt_Name.Text = "";

                Txt_Name.ForeColor = Color.Maroon;
            }
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Pass_Enter(object sender, EventArgs e)
        {
            if (Txt_Pass.Text == "Enter Your Password")
            {
                Txt_Pass.Text = "";

                Txt_Pass.ForeColor = Color.Maroon;

                Txt_Pass.PasswordChar = '*';
            }
        }
    }
}
