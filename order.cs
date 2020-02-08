using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    class order : Store.Models
    {
        public order() : base("OrderTable")
        { }


        public void add_to_cart(String pCode, String qty,String sold_price)
        {
            try
            {
                int prod_ID = Int32.Parse(getProdId(pCode));//Int32.Parse("-105");
                //int prod_Qty = Int32.Parse(getProdQty(pCode));//Int32.Parse("-105");
                //Decimal sold_price = System.Convert.ToDecimal(supp_price);
                decimal prod_Price = System.Convert.ToDecimal(getProdPrice(pCode));//Int32.Parse("-105");
                decimal sprofit = (System.Convert.ToDecimal(sold_price) - prod_Price);
                String query = "exec take_order " + pCode + "," + qty+","+sold_price+","+sprofit;

               // if(DataBase.NonQuery())
               if(exec_query(query))
                {
                    MessageBox.Show("Data Entered Successfully ");
                }
               else
                {
                    MessageBox.Show("Data can not be  Entered");

                }
             //   SqlDataReader r = DataBase.Query(query);
               // DataTable result = new DataTable();
                //result.Load(r);

               // DataRow r1 = result.Rows[0];
                //object[] o = r1.ItemArray;
                //String val = (String)o[0];
                //var res1 = val.Trim();
                //r.Close();
                //MessageBox.Show("Data Entered Successfully ");
                //cust_Fields_clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return;
            }
        }


        public DataTable total_Amount()
        {
            try
            {

                String query = "exec total_amount" ;
                IAsyncResult r2 = DataBase.NonQuery(query);
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is not present");
                return null;
            }
        }




        public String getProdId(String pCode)
        {
            try
            { 
                String query = "select Product_ID from product where product_Code = '" + pCode + "'";
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String ret = (int)o[0] + "";
                return ret;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Data is not present");
                return null;
            }
        }

        public String getProdPrice(String pCode)
        {
            try
            {
                String query = "select Unit_Price from product where product_Code="+pCode;
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String ret = (Decimal)o[0] + "";
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is not present");
                return null;
            }
        }
        public String getProdQty(String pCode)
        {
            try
            {
                
                String query = "select distinct Stock.Quantity from Stock join Product on Stock.Product_ID = (select Product_ID from Product where Product_Code="+pCode;
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                DataRow r1 = result.Rows[0];
                object[] o = r1.ItemArray;
                String ret = (int)o[0] + "";
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data is not present");
                return null;
            }
        }



        public DataTable ord_detail(String id)
        {
            String query = "exec ord_detail "+id;
            return runquery(query);
        }
        
    }
}
