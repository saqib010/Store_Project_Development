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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pnl_home.Visible = true;
            pnl_home.SetBounds(293, 02, 1079, 790);//pnl_home.SetBounds(293, 02, 1079, 590)
            TakeOrderPanel.Visible = false;
            DisplayPanel.Visible = false;
            DisplaySupplierPanel.Visible = false;
            AddRecordPanel.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pnl_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_home.SetBounds(293, 02, 1079, 790);
           
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            DisplayPanel.Visible = false;
            DisplaySupplierPanel.Visible = false;
            TakeOrderPanel.Visible = false;
        }

        private void btn_Add_main_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(293, 02, 1079, 790);
            AddRecordPanel.Visible = true;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            DisplayPanel.Visible = false;
            TakeOrderPanel.Visible = false;
          
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            AddSupplierPanel.SetBounds(293, 02, 1079, 790);
            AddSupplierPanel.Visible = true;
            AddProductPanel.Visible = false;
            AddCustomerPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            TakeOrderPanel.Visible = false;
        }

        private void AddRecordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {

            AddProductPanel.SetBounds(293, 02, 1079, 790);
            AddProductPanel.Visible = true;
            AddSupplierPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerPanel.SetBounds(293, 02, 1079, 790);
            AddCustomerPanel.Visible = true;
            AddProductPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
        }

        private void AddProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(293, 02, 1079, 790);
            AddRecordPanel.Visible = true;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void btn_back_from_supplier_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(293, 02, 1079, 790);
            AddRecordPanel.Visible = true;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(293, 02, 1079, 790);
            AddRecordPanel.Visible = true;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void btn_display_Main_Click(object sender, EventArgs e)
        {
            DisplayPanel.SetBounds(293, 02, 1079, 790);
            DisplayPanel.Visible = true;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void btn_Cust_View_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(293, 02, 1079, 790);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "CUSTOMER RECORDS";

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void btn_Suplier_view_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(293, 02, 1079, 790);
            DisplaySupplierPanel.Visible = true;
           // DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "SUPPLIER RECORDS";
        }

        private void btn_bk_Customer_Click(object sender, EventArgs e)
        {
            DisplayPanel.SetBounds(293, 02, 1079, 790);
            DisplayPanel.Visible = true;
            DisplaySupplierPanel.Visible = false;
            //DisplayCustomerPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;


        }

        private void button18_Click(object sender, EventArgs e)
        {
            DisplayPanel.SetBounds(293, 02, 1079, 790);
            DisplayPanel.Visible = true;
            DisplaySupplierPanel.Visible = false;
            //DisplayCustomerPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void btn_Order_View_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(293, 02, 1079, 790);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "ORDER RECORDS";
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_prod_view_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(293, 02, 1079, 790);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "PRODUCT RECORDS";
        }

        private void btn_Stok_View_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(293, 02, 1079, 790);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "STOCK";
        }

        private void btn_Take_Order_Click(object sender, EventArgs e)
        {
            TakeOrderPanel.SetBounds(293, 02, 1079, 790);
            TakeOrderPanel.Visible = true;
            DisplaySupplierPanel.Visible = false;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }
    }
}
