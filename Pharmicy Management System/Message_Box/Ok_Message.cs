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
    public partial class Ok_Message : Form
    {
        public Ok_Message()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicine_Search Medicine_Search_Frm = new Medicine_Search();
            //Medicine_Search_Frm.Show();
            return;
        }
    }
}
