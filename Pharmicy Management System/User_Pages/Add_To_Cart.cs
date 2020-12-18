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
    public partial class Add_To_Cart : Form
    {
        public Add_To_Cart()
        {
            InitializeComponent();
        }

        public List<Add_To_Cart_Class> Values { get; set; }

        public void AddToGrid(List<Add_To_Cart_Class> val)
        {

            if (val != null)
            {
                foreach (Add_To_Cart_Class item in val)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.S_No;
                    dataGridView1.Rows[n].Cells[1].Value = item.Disease_Name;
                    dataGridView1.Rows[n].Cells[2].Value = item.Medicine_Name;
                    dataGridView1.Rows[n].Cells[3].Value = item.Formula;
                    dataGridView1.Rows[n].Cells[4].Value = item.Price;
                    dataGridView1.Rows[n].Cells[5].Value = item.Manufacturers_Name;
                    dataGridView1.Rows[n].Cells[6].Value = item.Frequency;
                    dataGridView1.Rows[n].Cells[7].Value = item.Before_Eating;
                    dataGridView1.Rows[n].Cells[8].Value = item.After_Eating;
                    dataGridView1.Rows[n].Cells[9].Value = item.Adult_Dosage;
                    dataGridView1.Rows[n].Cells[10].Value = item.Paedriatic_Dosage;
                    dataGridView1.Rows[n].Cells[11].Value = item.Neonatal_Dosage;
                    dataGridView1.Rows[n].Cells[12].Value = item.Drug_Form;
                    dataGridView1.Rows[n].Cells[13].Value = item.Disease_Stage;
                    dataGridView1.Rows[n].Cells[14].Value = item.Molecular_Formula;
                    dataGridView1.Rows[n].Cells[15].Value = item.Quantity;
                }
            }
        }

        private void Add_To_Cart_Load(object sender, EventArgs e)
        {
            AddToGrid(Values);

            Order_Number_txt.Enabled = false;
            Random ran = new Random();
            int num = ran.Next(10000000, 99999999);
            Order_Number_txt.Text = num.ToString();
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

        private void AutoCalulateTotal()
        {
            int a = int.Parse(Txt_Total.Text);
            int sum = (a) - ((a * 5) / 100);
            Txt_Total.Text = sum.ToString();
            //ans=(1000)-((1000*5)/100)) 

        }
        private void Btn_Discount_Click(object sender, EventArgs e)
        {
            AutoCalulateTotal();
        }

        private void Total_Btn_Click(object sender, EventArgs e)
        {
            //int sum = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[16].Value);
            //}
            //int count_row = dataGridView1.Rows.Count;
            //double add = sum + count_row;
            //this.Txt_Total.Text = sum.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal qty = 0;
            decimal price = 0;

            if (dataGridView1.CurrentRow.Cells["Quantity"].Value != null && dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString().Trim() != "")
            {
                qty = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Quantity"].Value);
            }
            if (dataGridView1.CurrentRow.Cells["Price"].Value != null && dataGridView1.CurrentRow.Cells["Price"].Value.ToString().Trim() != "")
            {
                price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Price"].Value);
            }

            dataGridView1.CurrentRow.Cells["Amount"].Value = qty * price;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[16].Value);
            }
            int count_row = dataGridView1.Rows.Count;
            double add = sum + count_row;
            this.Txt_Total.Text = sum.ToString();

            //Disable Column of Amount
            int n = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                dataGridView1.Rows[i].Cells[1].ReadOnly = true;
                dataGridView1.Rows[i].Cells[2].ReadOnly = true;
                dataGridView1.Rows[i].Cells[3].ReadOnly = true;
                dataGridView1.Rows[i].Cells[4].ReadOnly = true;
                dataGridView1.Rows[i].Cells[5].ReadOnly = true;
                dataGridView1.Rows[i].Cells[6].ReadOnly = true;
                dataGridView1.Rows[i].Cells[7].ReadOnly = true;
                dataGridView1.Rows[i].Cells[8].ReadOnly = true;
                dataGridView1.Rows[i].Cells[9].ReadOnly = true;
                dataGridView1.Rows[i].Cells[10].ReadOnly = true;
                dataGridView1.Rows[i].Cells[11].ReadOnly = true;
                dataGridView1.Rows[i].Cells[12].ReadOnly = true;
                dataGridView1.Rows[i].Cells[13].ReadOnly = true;
                dataGridView1.Rows[i].Cells[14].ReadOnly = true;
                dataGridView1.Rows[i].Cells[16].ReadOnly = true;
                
                //dataGridView1.Rows[i].Cells[15].ErrorText.ToString();
            }
            //End

            //if (dataGridView1["Amount"] <= 0)
            //{
            //    MessageBox.Show("");
            //}

           
        }

        private void Btn_Purchase_Click(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    string StrQuery = @"INSERT INTO Add_To_Cart(Order_Number,Total_Amount) VALUES (" + Order_Number_txt.Text+"," + dataGridView1.Rows[i].Cells["Medicine_Name"].Value + ", " + dataGridView1.Rows[i].Cells["Formula"].Value + ", " + dataGridView1.Rows[i].Cells["Price"].Value + ", " + dataGridView1.Rows[i].Cells["Manufacturers_Name"].Value + ", " + dataGridView1.Rows[i].Cells["Drug_Form"].Value + ", " + dataGridView1.Rows[i].Cells["Quantity"].Value + ", " + dataGridView1.Rows[i].Cells["Total_Amount"].Value + ", " + Txt_Total.Text + ");";

            //    try
            //    {
            //        SqlConnection conn = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");
            //        //SqlConnection conn = new SqlConnection();
            //        conn.Open();

            //        using (SqlCommand comm = new SqlCommand(StrQuery, conn))
            //        {
            //            comm.ExecuteNonQuery();
            //        }
            //        conn.Close();

            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}

            

            SqlConnection con = new SqlConnection(@"Data Source=MUHAMMADMAAZPC\SQLEXPRESS;Initial Catalog=Pharmacy Portal;Integrated Security=True");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Add_To_Cart (Order_Number,Medicine_Name,Formula,Price,Manufacturers_Name,Drug_Form,Quantity,Total_Amount)VALUES('" + Order_Number_txt.Text + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[12].Value + "','" + dataGridView1.Rows[i].Cells[15].Value + "','"+ Txt_Total.Text + "')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                //DialogResult dialogResult = MessageBox.Show("Sure", " Add To Cart", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    //do something
                //    this.Hide();
                //    Medicine_Search Medicine_Search_Frm = new Medicine_Search();
                //    Medicine_Search_Frm.Show();
                //}
                //else if (dialogResult == DialogResult.No)
                //{
                //    //do something else
                //    this.Hide();
                //    Add_To_Cart Add_To_Cart_Frm = new Add_To_Cart();
                //    Add_To_Cart_Frm.Show();
                //}
            }
           
            dataGridView1.Rows.Clear();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine_Search Medicine_Search_Frm = new Medicine_Search();
            Medicine_Search_Frm.Show();
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

        //For Quantity Enter Only Number
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Quantity"].Index) //this is our numeric column
            {
                int i;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                }
            }
        }
        //End
    }
}
