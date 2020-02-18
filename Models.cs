using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        ///

        public Boolean insert(List<String> attributes)
        {
            string query="Exec Add_"+tableName ;
            String q;
            /**IF table name is customer and all fields **/

            if (tableName == "Customer")
            {
                query = " ";


            } 

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
            {
                query += " ";
                for (int i = 0; i < attributes.Count; i++)
                {
                    
                    if (i == attributes.Count - 1)
                    {
                        query +=   attributes[i] ;
                    }
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

            DataTable result = new DataTable();
            result = runquery(query);


            DataRow r1 = result.Rows[0];
            String val = r1.ItemArray[0].ToString();

            if (val.Equals("0"))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

       
 
        //*****##############Get the tables and search functions/// *********************##############

        public DataTable get()
        {
            if (!tableName.Equals("OrderTable"))
            {
                return runquery("Select * from " + tableName);
            }
            else
                return runquery("select * from OrderTable where Order_ID!= (Select Max(Order_ID) from OrderTable)");
        }
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

    
    }
}
