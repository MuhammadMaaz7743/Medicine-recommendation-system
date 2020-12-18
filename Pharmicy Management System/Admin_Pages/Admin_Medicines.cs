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
    public partial class Admin_Medicines : Form
    {
        public Admin_Medicines()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Login_Frm = new Login_Form();
            Login_Frm.Show();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Main_Page Main_Frm = new Admin_Main_Page();
            Main_Frm.Show();
        }

        private void Btn_Facebook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/mohammad.maaz.334");
            }
        }

        private void Admin_Medicines_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;

            Txt_S_No.Enabled = false;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Maroon;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            con.Open();                                          
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Diseases (Disease_Name,Medicine_Name,Formula,Price,Manufacturers_Name,Frequency,Before_Eating,After_Eating,Adult_Dosage,Paedriatic_Dosage,Neonatal_Dosage,Drug_Form,Disease_Stage,Molecular_Formula) VALUES ('" + Txt_Dis_Name .Text+ "','" + Txt_Med_Name.Text + "','" + Txt_Form.Text + "','" + Txt_Price.Text + "','" + Txt_Maunfac.Text + "','" + ComboBox_Frequ.Text + "','" + ComboBox_Bef_Eat.Text + "','" + ComboBox_Aft_Eat.Text + "','" + Txt_Adu_Dos.Text + "','" + Txt_Pae_Dos.Text + "','" + Txt_Neo_Dos.Text + "','" + ComboBox_Drug_Frm.Text + "','" + Txt_Dis_Stage.Text + "','" + Txt_Mole_Frm.Text + "') ",con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save Successfully!");
            Txt_S_No.Clear();
            Txt_Dis_Name.Clear();
            Txt_Med_Name.Clear();
            Txt_Form.Clear();
            Txt_Price.Clear();
            Txt_Maunfac.Clear();
            Txt_Adu_Dos.Clear();
            Txt_Pae_Dos.Clear();
            Txt_Neo_Dos.Clear();
            Txt_Dis_Stage.Clear();
            Txt_Mole_Frm.Clear();
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Diseases", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("UPDATE Diseases SET Disease_Name='" + Txt_Dis_Name.Text + "',Medicine_Name='" + Txt_Med_Name.Text + "',Formula='" + Txt_Form.Text + "',Price='" + Txt_Price.Text + "',Manufacturers_Name='" + Txt_Maunfac.Text + "',Frequency='" + ComboBox_Frequ.Text + "',Before_Eating='" + ComboBox_Bef_Eat.Text + "',After_Eating='" + ComboBox_Aft_Eat.Text + "',Adult_Dosage='" + Txt_Adu_Dos.Text + "',Paedriatic_Dosage='" + Txt_Pae_Dos.Text + "',Neonatal_Dosage='" + Txt_Neo_Dos.Text + "',Drug_Form='" + ComboBox_Drug_Frm.Text + "',Disease_Stage='" + Txt_Dis_Stage.Text + "',Molecular_Formula='" + Txt_Mole_Frm.Text + "' WHERE S_No='"+Txt_S_No.Text+"'", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully!"); 
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Txt_S_No.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Txt_Dis_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Txt_Med_Name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Txt_Form.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Txt_Price.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Txt_Maunfac.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            ComboBox_Frequ.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            ComboBox_Bef_Eat.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            ComboBox_Aft_Eat.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Txt_Adu_Dos.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            Txt_Pae_Dos.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Txt_Neo_Dos.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            ComboBox_Drug_Frm.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            Txt_Dis_Stage.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            Txt_Mole_Frm.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Diseases WHERE S_No='" + Txt_S_No.Text + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Medicines_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Medicines admin_Medicines_Frm = new Admin_Medicines();
            admin_Medicines_Frm.Show();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }

        private void Btn_Purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            All_Purchase All_Purchase_Frm = new All_Purchase();
            All_Purchase_Frm.Show();
        }
    }
}
