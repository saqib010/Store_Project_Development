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
        public supliers() : base("Supplier")
        { }
        public DataTable Supplier_ID_List()
        {
            return runquery("select Name from Supplier");
        }

    }
}
