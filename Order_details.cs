﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Order_details : Form
    {
        public Order_details(DataTable dt, String val)
        {
            InitializeComponent();
            grid_ord_Detail.DataSource = dt;


            Text_total_amount.Text = val;
        }

        private void btn_ord_show_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}