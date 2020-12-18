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

namespace Pharmicy_Management_System
{
    public partial class Formula_Search : Form
    {
        public Formula_Search()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Diseases WHERE Formula LIKE '" + TextBox_Formula.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading_Frm Loading_Frm = new Loading_Frm();
            Loading_Frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        private void Formula_Search_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            timer1.Enabled = true;
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
