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
        DataTable result;
        DataRow r1;

        public supliers() : base("Supplier")
        { }
        public DataTable Supplier_ID_List()
        {
            return runquery("select Name from Supplier");
        }
        public DataTable sales(String SupplierName)
        {
            return getSale("exec Supplier_Product '" + SupplierName + "'");
        }
        public DataTable totalsale(String SupplierName)
        {
           return getSale("exec TotalSale '" + SupplierName + "'");

        }
        public Boolean check_name_existance(String name, String phn)
        {
            result = runquery("exec check_supplierName_validation '"+name+"','"+phn+"'");
            r1 = result.Rows[0];
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
        private DataTable getSale(String query)
        {
            result = runquery(query);
            r1 = result.Rows[0];
            String val = r1.ItemArray[0].ToString();

            if (val.Equals("0"))
            {
                return null;
            }
            else
            {
                return result;
            }

        }
    
    }
}
