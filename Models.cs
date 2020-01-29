﻿using System;
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

            else if (tableName == "supplier")
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

            else if (tableName == "Products")
            {
                query = " ";

            }
            try
            {

                SqlDataReader r = DataBase.Query(query);
                r.Close();
                return true;
            }
                
            
            catch (Exception ex)
            {
                //ex is the error 
                return false;
            }
        }

       
 
        //*****##############Get the tables and search functions/// *********************##############

        public DataTable get()
        {
            SqlDataReader r = DataBase.Query("Select * from " + tableName);
            DataTable result = new DataTable();
            result.Load(r);
            return result;
        }

        public DataTable getBY_ID(String id)
        {
            SqlDataReader r = DataBase.Query("Select * from " + tableName + " where iD  = " + id + "");
            DataTable result = new DataTable();
            result.Load(r);
            r.Close();
            return result;
        }


// *****############## Updating Query area bu attribute list/// *********************##############

        public Boolean set(List<Attribute> SetAttributes, List<Attribute> WhereAttributes)
        {
            string query = "Update " + tableName + " SET ";
           
            
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


// *****############## Delete function/// *********************##############

        public Boolean delete(string id)
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
        }

    
    }
}
