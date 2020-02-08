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
        Store.Models model;
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
            TakeOrderPanel.Visible = false;
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
            TakeOrderPanel.Visible = false;

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
            set_SupplierNameCombo();
        }
        private void set_SupplierNameCombo()
        {
            //DataBase_A.Supliers cust = new DataBase_A.S();
            Store.supliers sup = new Store.supliers();
            // DataTable dt = sup.supplier_ID_List();
            DataTable dt = sup.Supplier_ID_List();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SupplierNameComboBox.Items.Add(dt.Rows[i]["Name"]);
            }


        }

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
            model = new Store.supliers();
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            get_Table();

            DisplaySupplierPanel.Visible = true;
            clear_grid_pnl_fields();
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
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            pnl_suplier_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_Order_fields.Visible = false;
            btn_display_Main_Click(sender, e);


        }

        private void btn_Order_View_Click(object sender, EventArgs e)
        {
            model = new Store.order();
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
            DataGridView.DataSource = new Store.stock().display_order();
            //get_Table();
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
            model = new Store.product();
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            get_Table();

            DisplaySupplierPanel.Visible = true;

            clear_grid_pnl_fields();
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            label98.Text = "PRODUCT RECORDS";
        }
        private void clear_grid_pnl_fields()
        {
            pnl_Order_fields.Visible = false;
            pnl_prod_fields.Visible = false;
            pnl_stok_fields.Visible = false;
            pnl_suplier_fields.Visible = false;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

        }

        private void btn_Stok_View_Click(object sender, EventArgs e)
        {
            model = new Store.stock();
            DisplaySupplierPanel.SetBounds(302, 02, 1055, 624);
            DisplaySupplierPanel.Visible = true;
            DataGridView.DataSource = new Store.stock().display_stock();
            //DisplayCustomerPanel.Visible = false;
            DisplayPanel.Visible = false;
            AddRecordPanel.Visible = false;
            clear_grid_pnl_fields();
            pnl_home.Visible = false;
            //AddCustomerPanel.Visible = false;
            AddSupplierPanel.Visible = false;
            AddProductPanel.Visible = false;
            TakeOrderPanel.Visible = false;
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

        private void get_Table()
        {
            DataTable dt = model.get();
            DataGridView.DataSource = dt;
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
            List<String> ls1 = new List<string>(3);
            if (String.IsNullOrEmpty(SupplierNameTextBox.Text) || String.IsNullOrEmpty(SupplierAddressTextBox.Text) || String.IsNullOrEmpty(SupplierPhoneTextBox.Text))
            {

                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsAlphas_Only(SupplierNameTextBox.Text) && IsDigitsOnly(SupplierPhoneTextBox.Text))
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
            ProductCodeTextBox.Text = "";
            ProductSizeComboBox.Text = "";
            ProductNameTextBox.Text = "";
            ProductQuatityTextBox.Text = "";
            ProductPriceTextBox.Text = "";
        }

        private static bool IsDigitsOnly(string str)
        {
            int i = 1;
            foreach (char c in str)
            {
                if (i == 1)
                {
                    if (c < '0' || c > '9')
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

        private void AddPrdButton_Click(object sender, EventArgs e)
        {
            List<String> ls1 = new List<string>(6);
            if (String.IsNullOrEmpty(SupplierNameComboBox.Text) || String.IsNullOrEmpty(ProductNameTextBox.Text) || String.IsNullOrEmpty(ProductCodeTextBox.Text) || String.IsNullOrEmpty(ProductSizeComboBox.Text) || String.IsNullOrEmpty(ProductQuatityTextBox.Text) || String.IsNullOrEmpty(ProductPriceTextBox.Text))
            {
                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsAlphas_Only(SupplierNameComboBox.Text) && IsAlphas_Only(ProductNameTextBox.Text) && IsDigitsOnly(ProductCodeTextBox.Text) && IsAlphas_Only(ProductSizeComboBox.Text) && IsDigitsOnly(ProductQuatityTextBox.Text))
            {
                if (IsDigitsOnly(ProductPriceTextBox.Text) || IsDecimal(ProductPriceTextBox.Text))
                {
                    ls1.Add(SupplierNameComboBox.Text);
                    ls1.Add(ProductCodeTextBox.Text);
                    ls1.Add(ProductNameTextBox.Text);
                    ls1.Add(ProductSizeComboBox.Text);
                    ls1.Add(ProductQuatityTextBox.Text);
                    ls1.Add(ProductPriceTextBox.Text);
                    if (new Store.product().insert(ls1))
                    {
                        MessageBox.Show("Data Entered Successfully ");
                        cust_Fields_clear();
                    }
                    else
                        MessageBox.Show("Sorry, data can not be entered");
                }
                else
                    MessageBox.Show("Provide Price Correcty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Provide only Text Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
        private bool IsDecimal(String value)
        {
            decimal number;
            return Decimal.TryParse(value, out number);

        }

        private void ClearPrdButton_Click(object sender, EventArgs e)
        {
            cust_Fields_clear();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (model is Store.product)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_prod_fields.SetBounds(296, 423, 684, 173);
                    pnl_prod_fields.Visible = true;
                    // pnl_stok_fields.Visible = false;
                    pnl_suplier_fields.Visible = false;
                    //pnl_Order_fields.Visible = false;
                    //btn_prod_update.Enabled = true;


                    int index = e.RowIndex;
                    Text_prod_code.Text = DataGridView.Rows[index].Cells[1].Value.ToString();
                    Text_prod_Name.Text = DataGridView.Rows[index].Cells[2].Value.ToString();
                    combo_prod_size.Text = DataGridView.Rows[index].Cells[3].Value.ToString();
                    Text_prod_price.Text = DataGridView.Rows[index].Cells[5].Value.ToString();
                    text_prod_qty.Text = DataGridView.Rows[index].Cells[4].Value.ToString();

                }

            }
            else if (model is Store.order)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_Order_fields.SetBounds(296, 406, 317, 139);
                    pnl_Order_fields.Visible = true;
                    pnl_stok_fields.Visible = false;
                    pnl_suplier_fields.Visible = false;
                    pnl_prod_fields.Visible = false;

                    int index = e.RowIndex;
                    txt_search_this_order.Text = DataGridView.Rows[index].Cells[0].Value.ToString();

                }
            }
            if (model is Store.supliers)
            {
                if (e.RowIndex >= 0)
                {
                    pnl_prod_fields.Visible = false;
                    pnl_Order_fields.Visible = false;
                    pnl_stok_fields.Visible = false;

                    pnl_suplier_fields.Visible = true;
                    pnl_suplier_fields.SetBounds(296, 406, 349, 206);


                    int index = e.RowIndex;

                    text_sup_Name.Text = DataGridView.Rows[index].Cells[1].Value.ToString();
                    text_sup_Address.Text = DataGridView.Rows[index].Cells[2].Value.ToString();
                    text_sup_phn.Text = DataGridView.Rows[index].Cells[3].Value.ToString();
                }
            }
            else if (model is Store.stock)
            {
                if (e.RowIndex >= 0)
                {

                    pnl_stok_fields.SetBounds(296, 413, 688, 189);
                    pnl_stok_fields.Visible = true;
                    pnl_suplier_fields.Visible = false;
                    pnl_Order_fields.Visible = false;
                    pnl_prod_fields.Visible = false;


                    int index = e.RowIndex;
                    Text_stock_prod_qty.Text = DataGridView.Rows[index].Cells[3].Value.ToString();
                    Text_stok_sell.Text = DataGridView.Rows[index].Cells[4].Value.ToString();
                    txt_stock_prod_name.Text = DataGridView.Rows[index].Cells[1].Value.ToString();
                    txt_stock_suplier_name.Text = DataGridView.Rows[index].Cells[2].Value.ToString();

                }

            }
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_ord_detial_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_search_this_order.Text != "")
                {
                    Store.order ord = new Store.order();
                    DataTable dt = ord.ord_detail(txt_search_this_order.Text);
                    DataTable dt1 = ord.total_Amount();
                    DataRow r1 = dt1.Rows[0];
                    object[] o = r1.ItemArray;

                    string value = o[0].ToString();
                    Store.Order_details detail = new Store.Order_details(dt, value);
                    detail.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show("Data is not present !", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            getSearched_table();
        }
        private void getSearched_table()
        {
            int i = 0;
            if (!OpenSearch(i))
            {
                txt_search.Text = "";
                get_Table();
            }
        }
        /*Open
         * search logic*/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private Boolean OpenSearch(int i)
        {
            List<string> columns = new List<string>();
            for (int j = 0; j < DataGridView.Columns.Count; j++)
            {
                columns.Add(DataGridView.Columns[j].DataPropertyName);
            }

            DataTable dt = model.getOpen(txt_search.Text, columns);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)

            {
                MessageBox.Show("There is Nothing Like  " + txt_search.Text, "Search Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                DataGridView.DataSource = dt;
                return true;
            }
        }

        private void btn_search_reset_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            clear_grid_pnl_fields();
            cust_Fields_clear();
            if(model is Store.stock)
            {
                 new Store.stock().display_stock();
            }
            else
            get_Table();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (model is Store.product)
            {
                if (IsAlphas_Only(Text_prod_Name.Text) && IsDigitsOnly(Text_prod_code.Text) && IsDecimal(Text_prod_price.Text) && combo_prod_size.SelectedItem != null)
                {
                    String[] ar = { "Product_Code", "'" + Text_prod_code.Text + "'", "Name", "'" + Text_prod_Name.Text + "'", "size", "'"+combo_prod_size.SelectedItem.ToString()+"'", "Unit_price", Text_prod_price.Text };
                    List<Store.Attribute> record = Store.Attribute.fromArray(ar);
                    Update_record(record);
                    btn_prod_view_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data is not correct ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }

            }
            else if (model is Store.supliers)
            {
                if (IsAlphas_Only(text_sup_Name.Text) && IsDigitsOnly(text_sup_phn.Text))
                {
                    String[] ar = { "Name", "'" + text_sup_Name.Text + "'", "Address", "'" + text_sup_Address.Text + "'", "PhoneNo", text_sup_phn.Text };
                    List<Store.Attribute> record = Store.Attribute.fromArray(ar);

                    Update_record(record);
                    btn_Suplier_view_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(" Invalid data is entered ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                }
            }
            else if (model is Store.stock)
            {
                if (txt_import.Text.Length>0 && IsDigitsOnly(txt_import.Text))
                {
                    Store.stock st = new Store.stock();
                    if(st.update_stock(Convert.ToInt32(DataGridView.Rows[DataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()),txt_import.Text))
                    MessageBox.Show(" Record Successfully Updated ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txt_import.Text = "";
                    btn_Stok_View_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Please provide a valid import quantity ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                }

            }
            else
            {
                MessageBox.Show(" invalid data is entered ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbfont"></param>
        /// <param name="cbfont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>
        /// 
        /// 
        /// *********************############## function to create update list attributes/// *********************##############
        /// 
        private void Update_record(List<Store.Attribute> record)
        {
            try
            {

                if (model.set(record, Convert.ToInt32(DataGridView.Rows[DataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString())))
                {
                    MessageBox.Show(" Record Successfully Updated ! ", "Updated Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show(" Updation is not possible ", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Updation is not possible", "Incorrect Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<String> ls1 = new List<string>(6);
            if(String.IsNullOrEmpty(ProductCodeOrder.Text)|| String.IsNullOrEmpty(SoldQuantityOrder.Text)|| String.IsNullOrEmpty(SoldUnitPriceOrder.Text))
            {
                MessageBox.Show("Enter * Fields Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (IsDigitsOnly(ProductCodeOrder.Text)&& IsDigitsOnly(SoldQuantityOrder.Text))
                {
                     if(IsDigitsOnly(SoldUnitPriceOrder.Text)|| IsDecimal(SoldUnitPriceOrder.Text))
                    {
                        Store.order ord = new Store.order();
                        ord.add_to_cart(ProductCodeOrder.Text,SoldQuantityOrder.Text,SoldUnitPriceOrder.Text);
                        ProductCodeOrder.Text = "";
                        SoldQuantityOrder.Text = "";
                        SoldUnitPriceOrder.Text = "";

                    }
                     else
                        MessageBox.Show("Provide Price Correcty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            
            
        }
        
        private void button26_Click(object sender, EventArgs e)
        {
            btn_bk_Customer_Click(sender,e);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Store.order ord = new Store.order();
           TotalBillGridView.DataSource=ord.total_Amount();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbfont"></param>
        /// <param name="cbfont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>
        /// 
        /// 
        /// *********************############## BUttons to display all /// *********************##############
        /// 

    }
}


