﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text=="admin"&& txtpassword.Text=="1234")
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {

        }
    }
}
