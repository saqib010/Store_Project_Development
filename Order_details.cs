using System;
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
        public Order_details()
        {
            InitializeComponent();
        }

        public void setBills(DataTable dt, String bill, String profit)
        {
            Text_total_amount.Visible = true;
            Text_total_profit.Visible = true;
            btnTotalSale.Visible = false;
            combosuppliername.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            btnSalesName.Visible = false;
            label20.Visible = false;
            label4.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker3.Visible = false;
            btn_get_accounts.Visible = false;

            label3.Visible = false;

            Show_data_on_grid(dt);


            Text_total_amount.Text = bill;
            Text_total_profit.Text = profit;
        }
        private void btn_ord_show_back_Click(object sender, EventArgs e)
        {
            this.Close();
}
        public void setsales()
        {
            combosuppliername.Visible = true;
            Text_total_amount.Visible = false;
            Text_total_profit.Visible = false;
            btnTotalSale.Visible = true;
            dateTimePicker1.Visible = false;
            dateTimePicker3.Visible = false;
            btn_get_accounts.Visible = false;
            label20.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            btnSalesName.Visible = true;
            setCombo();
           // get_sales_details();

        }

        private void setCombo()
        {
            combosuppliername.Items.Clear();
            DataTable dt = new Store.supliers().Supplier_ID_List();
            if (dt != null)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    combosuppliername.Items.Add(dt.Rows[i]["Name"]);
                }
            else
                MessageBox.Show("Supplier names are not present", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalesName_Click(object sender, EventArgs e)
        {
            if (combosuppliername.Text != "")
            {
                DataTable dt = new Store.supliers().sales(combosuppliername.SelectedItem.ToString());
                checkDataTable(dt);
            }else
                MessageBox.Show("Please select the Supplier Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Show_data_on_grid(DataTable dt)
        {
            grid_ord_Detail.DataSource = null;
            grid_ord_Detail.DataSource = dt;

        }

        private void btnTotalSale_Click(object sender, EventArgs e)
        {
            if (combosuppliername.Text != "")
            {
                DataTable dt = new Store.supliers().totalsale(combosuppliername.SelectedItem.ToString());
                checkDataTable(dt);
            }
            else
                MessageBox.Show("Please select the Supplier Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void checkDataTable(DataTable dt)
        {
            if (dt != null)
            {
                Show_data_on_grid(dt);
            }
            else
                MessageBox.Show("Product sales details are not present", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void set_accounts()
        {
            Text_total_amount.Visible = false;
            Text_total_profit.Visible = false;
            btnTotalSale.Visible = false;
            combosuppliername.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnSalesName.Visible = false;
            label20.Visible = true;
            label4.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker3.Visible = true;
            btn_get_accounts.Visible = true;
            label3.Visible = false;

        }
        private void btn_get_accounts_Click(object sender, EventArgs e)
        {
           
            Show_data_on_grid(new Store.Models().runquery("exec proc_net_sale '"+dateTimePicker1.Text+"'"+",'"+dateTimePicker3.Text+"'")) ;

        }
    }

}

