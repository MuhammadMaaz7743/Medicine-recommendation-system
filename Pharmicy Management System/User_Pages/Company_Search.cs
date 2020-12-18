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
    public partial class Company_Search : Form
    {
        public Company_Search()
        {
            InitializeComponent();
            Fill_Combo();
        }

        void Fill_Combo()
        {
            string constring = @"Data Source = MUHAMMADMAAZPC\SQLEXPRESS; Initial Catalog = Pharmacy Portal; Integrated Security = True";
            string query = "SELECT * FROM Diseases ;";
            SqlConnection ConDataBase= new SqlConnection(constring);
            SqlCommand sc = new SqlCommand(query, ConDataBase);
            SqlDataReader MyReader;
            try
            {
                ConDataBase.Open();
                MyReader = sc.ExecuteReader();

                while (MyReader.Read())
                {
                    string sName = MyReader.GetString(MyReader.GetOrdinal("Manufacturers_Name"));
                    //string sName = MyReader.GetString("Manufacturers_Name");
                    //comboBox1.Items.Add(sName);
                    if (!ComboBox_Company_Search.Items.Contains(sName))
                        ComboBox_Company_Search.Items.Add(sName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Diseases WHERE Manufacturers_Name LIKE '" + ComboBox_Company_Search.Text + "%'" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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

        private void Company_Search_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        //private void Btn_Home_Click_1(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Home_Patient Login_Frm = new Home_Patient();
        //    Login_Frm.Show();
        //}
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
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

        private void Btn_About_us_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Us About_Us_Frm = new About_Us();
            About_Us_Frm.Show();
        }
        private void Btn_Company_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
