﻿using System;
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
    public partial class User_Name_Password : Form
    {
        public User_Name_Password()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form Login_Frm = new Login_Form();
            //Medicine_Search_Frm.Show();
            return;
        }
    }
}
