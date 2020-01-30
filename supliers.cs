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

           /* public DataTable Supplier_ID_List()
            {
                String query = "select Supplier_ID from Supplier";
                return runquery(query);
            }*/
        
    }
}
