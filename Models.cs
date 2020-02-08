using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Store
{
    class Models
    {
            public string tableName = "";

            public Models(string tableName)
            {
                this.tableName = tableName;
            }
        public Models() { }
        //*******************************gET IDs********************
        
       
        public DataTable runquery(String query)
        {
            try
            {
                
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //******************************************************

        ///*********INSERT QUERY TABLE
        public Boolean insert(List<String> attributes)
        {
            string query="Exec Add_"+tableName ;
            String q;
            /**IF table name is customer and all fields **/

            if (tableName == "Customer")
            {
                query = " ";


            } //EXEC add_Supplier 'dada','chota@gmail.com',456,'asd564','sdf',456,'2018-12-23'

            else if (tableName == "Supplier")
            {
                query += " ";
                for (int i = 0; i < attributes.Count; i++)
                {
                    if(i==attributes.Count-1)
                    {
                        query += "'" + attributes[i] + "'";
                    }
                    else
                    {
                        query += "'" + attributes[i] + "'" + ",";
                    }
                }
                query += "";
            }

            else if (tableName == "Product")
            {//1/4/5
                query += " ";
                for (int i = 0; i < attributes.Count; i++)
                {
                    
                    if (i == attributes.Count - 1)
                    {
                        query +=   attributes[i] ;
                    }//EXEC Add_Product 'aaaa',009,'Jeans','Small',4,66
                    else if (i==1||i == 4)
                    {
                        query += attributes[i] + ",";
                    }
                    else
                    {
                        query += "'" + attributes[i] + "'" + ",";
                    }
                }
                query += "";
            }
            //model = new DataBase_A.Supliers();
            //pnl_Cust.SetBounds(287, 26, 1069, 580);
            //get_Table();

            return exec_query(query);
        }

       
 
        //*****##############Get the tables and search functions/// *********************##############

        public DataTable get()
        {
            //SqlDataReader r = DataBase.Query();
            return runquery("Select * from " + tableName);
        }

       /* public DataTable getBY_ID(String id)
        {
            SqlDataReader r = DataBase.Query("Select * from " + tableName + " where iD  = " + id + "");
            DataTable result = new DataTable();
            result.Load(r);
            r.Close();
            return result;
        }*/
        public DataTable getOpen(String name, List<string> columns)
        {
            string query = "select * from " + tableName;

            query += " Where concat(";

            for (int i = 0; i < columns.Count; i++)
            {
                if (i != columns.Count - 1)
                {
                    query += columns[i] + " , ";

                }
                else
                {
                    query += columns[i] + ") ";
                }
            }
            query += "like('%" + name + "%')";

            return runquery(query);
        }


        // *****############## Updating Query area bu attribute list/// *********************##############

        public Boolean set(List<Attribute> SetAttributes, List<Attribute> WhereAttributes)
        {
            string query = "Update " + tableName + " SET ";
            for (int i = 0; i < SetAttributes.Count; i++)
            {
                if (i != SetAttributes.Count - 1)
                {
                    query += SetAttributes[i].Name + "=" + SetAttributes[i].Value + " , ";

                }
                else
                {
                    query += SetAttributes[i].Name + "=" + SetAttributes[i].Value;

                }
            }
            query += " Where ";

            for (int i = 0; i < WhereAttributes.Count; i++)
            {
                if (i != WhereAttributes.Count - 1)
                {
                    query += WhereAttributes[i].Name + "=" + WhereAttributes[i].Value + " and ";

                }
                else
                {
                    query += WhereAttributes[i].Name + "=" + WhereAttributes[i].Value;

                }
            }
            return exec_query(query);
        }

        public Boolean exec_query(String query)
        {
            try
            {
                SqlDataReader r = DataBase.Query(query);
                r.Close();
                return true;
            }
            catch (Exception ex)
            {
                //ex is the error object
                return false;
            }
        }

        public Boolean set(List<Attribute> SetAttributes, int whereId)
        {
            return set(SetAttributes, Attribute.fromArray(new string[] { tableName+"_ID", "" + whereId }));
        }

        // *****############## Delete function/// *********************##############

      /*  public Boolean delete(string id)
        {
            try
            {
                String query = "exec tb" + tableName + " " + id;
                // System.Windows.Forms.MessageBox.Show(query);
                if (System.Windows.Forms.MessageBox.Show("\nAll References May Also Be Deleted !", "Warning", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    SqlDataReader r = DataBase.Query(query);
                    r.Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                //ex is the error object
                return false;
            }
        }*/

    
    }
}
