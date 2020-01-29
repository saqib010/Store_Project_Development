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
    class supliers : Store.Models
    {
        public supliers() : base("supplier")
        { }

        public DataTable supplier_ID_List()
        {
            try
            {
                String query = "select ID from Supplier";
                SqlDataReader r = DataBase.Query(query);
                DataTable result = new DataTable();
                result.Load(r);
                r.Close();
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data", "Error");
                return null;
            }
        }
    }
}
