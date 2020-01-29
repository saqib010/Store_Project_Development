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
                String query = "exec Checklogin '" + name + "','" + pass + "'";
            return runquery(query);
        }

        public Boolean update(String name, String oldpass, String newpass)
        {
            if (validate(name, oldpass)) { 
                String query = "exec updatePassword '" + newpass + "','"+name+"'";
            return runquery(query);
                }
            else
            {
                return false;
            }
        
        }
        public Boolean runquery(String query)
        {
            try
            {
                SqlDataReader r = DataBase.Query(query);
            DataTable result = new DataTable();
            result.Load(r);

            DataRow r1 = result.Rows[0];
            String val = r1.ItemArray[0].ToString();

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
