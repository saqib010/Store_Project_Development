using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Store
{
    class Login_Class
    {
        public Boolean validate(String name, String pass)
        {

            try
            {
                String query = "exec Checklogin '" + name + "','" + pass + "'";
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);

                DataRow r1 = result.Rows[0];
                String val = r1.ItemArray[0].ToString();
                //String val = (String)o[0];
                // var res1 = val.Trim();

                if (val.Equals("1"))
                {
                    r.Close();
                    return true;
                }

                else
                {
                    r.Close();
                    return false;
                }

            }

            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
