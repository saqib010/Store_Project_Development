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
            pnl_home.SetBounds(302, 02, 1055, 624);
            pnl_home.Visible = true;
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
            pnl_home.SetBounds(302, 02, 1055, 624);
           
            AddRecordPanel.Visible = false;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            DisplayPanel.Visible = false;
            DisplaySupplierPanel.Visible = false;
          //  TakeOrderPanel.Visible = false;
        }

        private void btn_Add_main_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(302, 02, 1055, 624);
            AddRecordPanel.Visible = true;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            DisplayPanel.Visible = false;
           // TakeOrderPanel.Visible = false;
          
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            AddSupplierPanel.SetBounds(302, 02, 1055, 624);
            AddSupplierPanel.Visible = true;
            AddProductPanel.Visible = false;
           // AddCustomerPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
           // TakeOrderPanel.Visible = false;
        }

        private void AddRecordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {

            AddProductPanel.SetBounds(302, 02, 1055, 624);
            AddProductPanel.Visible = true;
            AddSupplierPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
           // AddCustomerPanel.Visible = false;
        }

       /* private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerPanel.SetBounds(302, 02, 1055, 624);
            AddCustomerPanel.Visible = true;
            AddProductPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
        }*/

        private void AddProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_Add_main_Click(sender, e);
        }

        private void btn_back_from_supplier_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(302, 02, 1055, 624);
            AddRecordPanel.Visible = true;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddRecordPanel.SetBounds(302, 02, 1055, 624);
            AddRecordPanel.Visible = true;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void btn_display_Main_Click(object sender, EventArgs e)
        {
            DisplayPanel.SetBounds(302, 02, 1055, 624);
            DisplayPanel.Visible = true;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            TakeOrderPanel.Visible = false;
            DisplaySupplierPanel.Visible = false;
        }

      /*  private void btn_Cust_View_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "CUSTOMER RECORDS";

        }*/

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void btn_Suplier_view_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
           // DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "SUPPLIER RECORDS";
        }

        private void btn_bk_Customer_Click(object sender, EventArgs e)
        {
            DisplayPanel.SetBounds(302, 02, 1055, 624);
            DisplayPanel.Visible = true;
            DisplaySupplierPanel.Visible = false;
            //DisplayCustomerPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;


        }

        private void button18_Click(object sender, EventArgs e)
        {
            btn_display_Main_Click(sender, e);

        }

        private void btn_Order_View_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "ORDER RECORDS";
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_prod_view_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "PRODUCT RECORDS";
        }

        private void btn_Stok_View_Click(object sender, EventArgs e)
        {
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "STOCK";
        }

        private void btn_Take_Order_Click(object sender, EventArgs e)
        {
            TakeOrderPanel.SetBounds(302, 02, 1055, 624);
            TakeOrderPanel.Visible = true;
            DisplaySupplierPanel.Visible = false;
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
           // AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;

        }

        private void btn_EXIT_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btn_display_Main_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn_Add_main_Click(sender, e);
        }

        private void AddSupButton_Click(object sender, EventArgs e)
        {
            List<String> ls1 = new List<string>(7);
            if(String.IsNullOrEmpty(SupplierNameTextBox.Text) || String.IsNullOrEmpty(SupplierAddressTextBox.Text) || String.IsNullOrEmpty(SupplierPhoneTextBox.Text))
            {
                /*
                   */
                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsAlphas_Only(SupplierNameTextBox.Text)  && IsDigitsOnly(SupplierPhoneTextBox.Text))
            {
                ls1.Add(SupplierNameTextBox.Text);
                ls1.Add(SupplierAddressTextBox.Text);
                ls1.Add(SupplierPhoneTextBox.Text);
                if (new Store.supliers().insert(ls1))
                {
                    MessageBox.Show("Data Entered Successfully ");
                    cust_Fields_clear();


                }
                else
                    MessageBox.Show("Sorry, data can not be entered");

            }

            else
                    {
                MessageBox.Show("Provide only Text Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cust_Fields_clear()
        {
            SupplierNameTextBox.Text = "";
            SupplierAddressTextBox.Text = "";
            SupplierPhoneTextBox.Text = "";
            
        }
        
            private static bool IsDigitsOnly(string str)
        {
            int i = 1;
            foreach (char c in str)
            {
                if (i == 1)
                {
                    if (c <= '0' || c > '9')
                    {
                        return false;
                    }
                    i++;
                }
                else if (c < '0' || c > '9')
                {
                    return false;
                }
                else
                {


                    if (Convert.ToInt32(c) > 0)
                        continue;
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool IsAlphas_Only(string str)
        {
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                    return false;
            }

            return true;
        }

        private void ClearSupButton_Click(object sender, EventArgs e)
        {
            cust_Fields_clear();
        }
    }
}
