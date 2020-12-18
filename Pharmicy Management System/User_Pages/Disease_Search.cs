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
    public partial class Medicine_Search : Form
    {
        public Medicine_Search()
        {
            InitializeComponent();
            //Fill_Combo();
        }

        //void Fill_Combo()
        //{
        //    string constring = @"Data Source = MUHAMMADMAAZPC\SQLEXPRESS; Initial Catalog = Pharmacy Portal; Integrated Security = True";
        //    string query = "SELECT * FROM Diseases ;";
        //    SqlConnection ConDataBase = new SqlConnection(constring);
        //    SqlCommand sc = new SqlCommand(query, ConDataBase);
        //    SqlDataReader MyReader;
        //    try
        //    {
        //        ConDataBase.Open();
        //        MyReader = sc.ExecuteReader();

        //        while (MyReader.Read())
        //        {
                    
        //            string sName = MyReader.GetString(MyReader.GetOrdinal("Disease_Name"));
        //            //string sName = MyReader.GetString("Manufacturers_Name");
        //            //comboBox4.Items.Add(sName);
        //            if (!ComboBox_Disease_A.Items.Contains(sName))
        //                ComboBox_Disease_A.Items.Add(sName);
        //            if (!ComboBox_Disease_B.Items.Contains(sName))
        //                ComboBox_Disease_B.Items.Add(sName);
        //            if (!ComboBox_Disease_C.Items.Contains(sName))
        //                ComboBox_Disease_C.Items.Add(sName);
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
            SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading_Frm Loading_Frm = new Loading_Frm();
            Loading_Frm.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Facebook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are u Sure To Visit Facebook", "Facebook Confirmation To Visit ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/mohammad.maaz.334");
            }
        }

        private void Medicine_Search_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
   
            this.AcceptButton = Btn_Search;

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


            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Disease_Name FROM Diseases " ,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //ComboBox_Disease_A.Items.Add("--SELECT--");
            foreach (DataRow ROW in dt.Rows)
            {
                ComboBox_Disease_A.Items.Add(ROW["Disease_Name"].ToString());
                ComboBox_Disease_B.Items.Add(ROW["Disease_Name"].ToString());
                ComboBox_Disease_C.Items.Add(ROW["Disease_Name"].ToString());
            }
           
        }

        //private void Btn_Search_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + comboBox4.Text + "'",con);
        //    //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Diseases WHERE Disease_Name LIKE '" + textBox1.Text + "%'", con);
        //    //SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM Diseases WHERE Disease_Name LIKE '" + textBox6.Text + "%'", con);
        //    //SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Diseases WHERE Disease_Name LIKE '" + textBox11.Text + "%'", con);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    //sda1.Fill(dt);
        //    //sda2.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        dataGridView1.DataSource = dt;
        //    }

        //    else
        //    {
        //        MessageBox.Show("Record Not Found!");
        //    }
        //    //dataGridView1.Refresh();
        //    //string str = sda.SelectCommand.ToString();
        //    //if (this.dataGridView1.Columns[str] == null)
        //    //{
        //    //    MessageBox.Show(str + " is not existed in the DataGridView");
        //    //    return;
        //    //}
        //    con.Close();
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Patient Login_Frm = new Home_Patient();
            Login_Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drug_Search Drug_Search_Frm = new Drug_Search();
            Drug_Search_Frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
        }

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

        private void Btn_Search_Click_1(object sender, EventArgs e)
        {
            con.Open();
            //if (ComboBox_Disease_A_1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select a value in ComboBox 2");
            //    con.Close();
            //    return;
            //}
            //if (ComboBox_Disease_B_1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select a value in ComboBox 2");
            //    con.Close();
            //    return;
            //}
            //if (ComboBox_Disease_C_1.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please select a value in ComboBox 2");
            //    con.Close();
            //    return;
            //}
            if (ComboBox_Disease_A.Text != "" && ComboBox_Disease_B.Text != "" && ComboBox_Disease_C.Text!= "")
            {
                if (ComboBox_Disease_A_1.SelectedIndex == -1 || ComboBox_Disease_B_1.SelectedIndex == -1 || ComboBox_Disease_C_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }
                string[] allTextBoxes = { ComboBox_Disease_A.Text, ComboBox_Disease_B.Text, ComboBox_Disease_C.Text }; // Put textboxes into an array.
                if (allTextBoxes.Distinct().Count() != allTextBoxes.Count()) // Check if the string has any duplicates.
                {
                    MessageBox.Show("You Select Same Data in Disease A & Disease B & Disease C");
                    this.Hide();
                    Medicine_Search Medicine_Search_Frm = new Medicine_Search();
                    Medicine_Search_Frm.Show();
                }
                
                //SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name LIKE '" + ComboBox_Disease_A.Text + "%'", con);
                //SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name LIKE '" + ComboBox_Disease_B.Text + "%'", con);
                //SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name LIKE '" + ComboBox_Disease_C.Text + "%'", con);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_A.Text + "' and Disease_Stage ='" + ComboBox_Disease_A_1.Text + "'", con);
                SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_B.Text + "' and Disease_Stage ='" + ComboBox_Disease_B_1.Text + "'", con);
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_C.Text + "' and Disease_Stage ='" + ComboBox_Disease_C_1.Text + "'", con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                sda1.Fill(dtb);
                sda2.Fill(dtb);


                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                }
                
                else
                {
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }
            }

            else if (ComboBox_Disease_A.Text!= "" && ComboBox_Disease_B.Text!= "")
            {
                if (ComboBox_Disease_A_1.SelectedIndex == -1 || ComboBox_Disease_B_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }
                string[] allTextBoxes = { ComboBox_Disease_A.Text, ComboBox_Disease_B.Text}; // Put textboxes into an array.
                if (allTextBoxes.Distinct().Count() != allTextBoxes.Count()) // Check if the string has any duplicates.
                {
                    MessageBox.Show("You Select Same Data in Disease A & Disease B ");
                    this.Hide();
                    Medicine_Search Medicine_Search_Frm = new Medicine_Search();
                    Medicine_Search_Frm.Show();
                }

                //SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_A.Text + "'", con);
                //SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_B.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_A.Text + "' and Disease_Stage ='" + ComboBox_Disease_A_1.Text + "'", con);
                SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_B.Text + "' and Disease_Stage ='" + ComboBox_Disease_B_1.Text + "'", con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                sda1.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                }

                else
                {
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }
            }
            else if (ComboBox_Disease_C.Text != "" && ComboBox_Disease_B.Text != "")
            {
                if (ComboBox_Disease_C_1.SelectedIndex == -1 || ComboBox_Disease_B_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }
                string[] allTextBoxes = { ComboBox_Disease_C.Text, ComboBox_Disease_B.Text }; // Put textboxes into an array.
                if (allTextBoxes.Distinct().Count() != allTextBoxes.Count()) // Check if the string has any duplicates.
                {
                    MessageBox.Show("You Select Same Data in Disease B & Disease C ");
                    this.Hide();
                    Medicine_Search Medicine_Search_Frm = new Medicine_Search();
                    Medicine_Search_Frm.Show();
                }

                //SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_B.Text + "'", con);
                //SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_C.Text + "'", con);
                SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_B.Text + "' and Disease_Stage ='" + ComboBox_Disease_B_1.Text + "'", con);
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_C.Text + "' and Disease_Stage ='" + ComboBox_Disease_C_1.Text + "'", con);
                DataTable dtb = new DataTable();
                sda1.Fill(dtb);
                sda2.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                }

                else
                {
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }

            }
            else if (ComboBox_Disease_A.Text != "" && ComboBox_Disease_C.Text != "")
            {
                if (ComboBox_Disease_A_1.SelectedIndex == -1 || ComboBox_Disease_C_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }
                string[] allTextBoxes = { ComboBox_Disease_A.Text, ComboBox_Disease_C.Text }; // Put textboxes into an array.
                if (allTextBoxes.Distinct().Count() != allTextBoxes.Count()) // Check if the string has any duplicates.
                {
                    MessageBox.Show("You Select Same Data in Disease A & Disease C ");
                    this.Hide();
                    Medicine_Search Medicine_Search_Frm = new Medicine_Search();
                    Medicine_Search_Frm.Show();
                }

                //SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_A.Text + "'", con);
                //SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_C.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_A.Text + "' and Disease_Stage ='" + ComboBox_Disease_A_1.Text + "'", con);
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_C.Text + "' and Disease_Stage ='" + ComboBox_Disease_C_1.Text + "'", con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                sda2.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                }

                else
                {
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }

            }
            else if(ComboBox_Disease_A.Text != "")
            {
                if (ComboBox_Disease_A_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }
               //SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases  Where Disease_Name ='" + ComboBox_Disease_A.Text + "' UNION select * From Diseases Where Disease_Stage ='"+ ComboBox_Disease_A_1.Text+"", con);
               //SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name =" + ComboBox_Disease_A.Text + "'"+ "UNION select * from Diseases where Disease_Stage ='" + ComboBox_Disease_A_1.Text + "'", con);
               SqlDataAdapter sda = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_A.Text + "' and Disease_Stage ='" + ComboBox_Disease_A_1.Text  + "'",con); 
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                    
                }

                else
                {
                    //dataGridView1.DataSource = dtb;
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }
            }

            else if (ComboBox_Disease_C.Text != "")
            {
                if (ComboBox_Disease_C_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }
                SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_C.Text + "' and Disease_Stage ='" + ComboBox_Disease_C_1.Text + "'", con);

                //SqlDataAdapter sda2 = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_C.Text + "'", con);
                DataTable dtb = new DataTable();
                sda2.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                }

                else
                {
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }
            }
            else if (ComboBox_Disease_B.Text != "")
            {
                if (ComboBox_Disease_B_1.SelectedIndex == -1)
                {
                    //MessageBox.Show("Please select a value in ComboBox 2");
                    Ok_Message ok_frm = new Ok_Message();
                    ok_frm.Show();
                    con.Close();
                    return;
                }

                SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name = '" + ComboBox_Disease_B.Text + "' and Disease_Stage ='" + ComboBox_Disease_B_1.Text + "'", con);
                //SqlDataAdapter sda1 = new SqlDataAdapter("select * from Diseases where Disease_Name ='" + ComboBox_Disease_B.Text + "'", con);
                DataTable dtb = new DataTable();
                sda1.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtb;
                }

                else
                {
                    //MessageBox.Show("No record Found!");
                    No_Data No_Data_frm = new No_Data();
                    No_Data_frm.Show();
                    con.Close();
                    return;
                }

            }
            else
            {
                //MessageBox.Show("You Enter No Record!");
                Enter_No_Record Enter_No_Record_frm = new Enter_No_Record();
                Enter_No_Record_frm.Show();
                con.Close();
                return;
            }

            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //sda1.Fill(dt);
            //sda2.Fill(dt);

            //sda1.Fill(dt);
            //sda2.Fill(dt);

            //if (dt.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = dt;
            //}

            //else
            //{
            //    MessageBox.Show("Record Not Found!");
            //}
            //dataGridView1.Refresh();
            //string str = sda.SelectCommand.ToString();
            //if (this.dataGridView1.Columns[str] == null)
            //{
            //    MessageBox.Show(str + " is not existed in the DataGridView");
            //    return;
            //}
            con.Close();

            //ComboBox_Disease_A.Items.Clear();
            ComboBox_Disease_A.Text = "";
            ComboBox_Disease_A_1.Items.Clear();
            ComboBox_Disease_A_1.Text = "";
            //ComboBox_Disease_B.Items.Clear();
            ComboBox_Disease_B.Text = "";
            ComboBox_Disease_B_1.Items.Clear();
            ComboBox_Disease_B_1.Text = "";
            //ComboBox_Disease_C.Items.Clear();
            ComboBox_Disease_C.Text = "";
            ComboBox_Disease_C_1.Items.Clear();
            ComboBox_Disease_C_1.Text = "";

            //return;
        }

        private void Btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ComboBox_Disease_A_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_Disease_A_1.Items.Clear();
            ComboBox_Disease_A_1.Text = "";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Disease_Stage FROM Diseases where Disease_Name='"+ComboBox_Disease_A.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow AB in dt.Rows)
            {
                ComboBox_Disease_A_1.Items.Add(AB["Disease_Stage"].ToString());
            }
        }

        private void ComboBox_Disease_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_Disease_B_1.Items.Clear();
            ComboBox_Disease_B_1.Text = "";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Disease_Stage FROM Diseases where Disease_Name='" + ComboBox_Disease_B.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow AB in dt.Rows)
            {
                ComboBox_Disease_B_1.Items.Add(AB["Disease_Stage"].ToString());
            }
        }

        private void ComboBox_Disease_C_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox_Disease_C_1.Items.Clear();
            ComboBox_Disease_C_1.Text = "";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Disease_Stage FROM Diseases where Disease_Name='" + ComboBox_Disease_C.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow AB in dt.Rows)
            {
                ComboBox_Disease_C_1.Items.Add(AB["Disease_Stage"].ToString());
            }
        }

        private void Btn_Add_To_Cart_Click(object sender, EventArgs e)
        {
           //For Not Selected Rows For AddToCart
            bool noRowsSelected = true;

            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                object temp = dataGridView1.Rows[i].Cells[0].Value;
                if (temp != null)
                {
                    noRowsSelected = false;
                    break;
                }
            }

            if (noRowsSelected)
            {
                MessageBox.Show("You must select one or more rows To Purchase !");
                return;
            }
            else
            {
                // what you had to start with
            }
            //End

            List<Add_To_Cart_Class> CV = new List<Add_To_Cart_Class>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    CV.Add(new Add_To_Cart_Class
                    {
                        S_No = item.Cells[1].Value.ToString(),
                        Disease_Name = item.Cells[2].Value.ToString(),
                        Medicine_Name = item.Cells[3].Value.ToString(),
                        Formula = item.Cells[4].Value.ToString(),
                        Price = item.Cells[5].Value.ToString(),
                        Manufacturers_Name = item.Cells[6].Value.ToString(),
                        Frequency = item.Cells[7].Value.ToString(),
                        Before_Eating = item.Cells[8].Value.ToString(),
                        After_Eating = item.Cells[9].Value.ToString(),
                        Adult_Dosage = item.Cells[10].Value.ToString(),
                        Paedriatic_Dosage = item.Cells[11].Value.ToString(),
                        Neonatal_Dosage = item.Cells[12].Value.ToString(),
                        Drug_Form = item.Cells[13].Value.ToString(),
                        Disease_Stage = item.Cells[14].Value.ToString(),
                        Molecular_Formula = item.Cells[15].Value.ToString(),
                        Quantity = item.Cells[16].Value.ToString()
                    });
                }
            }
            this.Hide();
            Add_To_Cart frm = new Add_To_Cart();
            frm.Values = CV;
            frm.Show();
        }

        private void ComboBox_Disease_A_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void ComboBox_Disease_B_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void ComboBox_Disease_C_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}
