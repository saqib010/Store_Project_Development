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
        DataTable result;
        String query;
        public order() : base("OrderTable")
        { }

       

        public void add_to_cart(String pCode, String qty,String sold_price)
        {
            try
            {
                int prod_ID = Int32.Parse(getProdId(pCode));//Int32.Parse("-105");
                //int prod_Qty = Int32.Parse(getProdQty(pCode));//Int32.Parse("-105");
                //Decimal sold_priced = System.Convert.ToDecimal(supp_price);
                decimal prod_Price = System.Convert.ToDecimal(getProdPrice(pCode));//Get Unit Price
                if(System.Convert.ToDecimal(sold_price) >= prod_Price)
                {
                    decimal sprofit = (System.Convert.ToDecimal(sold_price) - prod_Price);
                    query = "exec take_order " + pCode + "," + qty + "," + sold_price + "," + sprofit;
                    DataTable result = new DataTable();
                    result = runquery(query);


                    DataRow r1 = result.Rows[0];
                    String val = r1.ItemArray[0].ToString();

                    if (val.Equals("1"))
                    {
                        MessageBox.Show("Add to card updated Successfully ");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, We can not enter add to card!");

                    }

                }
                else
                {
                    MessageBox.Show("Enter Correct Price");

                }

                // if(DataBase.NonQuery())


                
/*
                if (exec_query(query))
                {
                    
                }*/
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data, TRY AGAIN", "Error");
                return;
            }
        }


        public DataTable total_bill()
        {
            try
            {

                query = "exec total_amount ";
                result = runquery(query);
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
                query = "select Product_ID from product where product_Code = '" + pCode + "'";
                result = runquery(query);
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
                query = "select Unit_Price from product where product_Code="+pCode;
                result = runquery(query);
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
                
                query = "select distinct Stock.Quantity from Stock join Product on Stock.Product_ID = (select Product_ID from Product where Product_Code="+pCode;
                result = runquery(query);
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
            query = "exec ord_detail " + id;
            return runquery(query);
        }

        public String getCurrent_detail()
        {
            result = runquery("select max(Order_ID) from OrderTable");
            DataRow r1 = result.Rows[0];
            object[] o = r1.ItemArray;
            String ret = (int)o[0] + "";
            return ret;
        }
        
    }
}
