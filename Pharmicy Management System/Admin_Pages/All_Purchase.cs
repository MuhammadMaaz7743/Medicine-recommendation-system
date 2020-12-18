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
    public partial class All_Purchase : Form
    {
        public All_Purchase()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");
        private void Btn_View_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Add_To_Cart" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Main_Page Admin_Main = new Admin_Main_Page();
            Admin_Main.Show();
        }

        private void Btn_Medicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Medicines Admin_Medi = new Admin_Medicines();
            Admin_Medi.Show();
        }

        private void Btn_Purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Purchase All_Purchase_Frm = new All_Purchase();
            All_Purchase_Frm.Show();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
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

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
