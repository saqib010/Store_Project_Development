using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class stock: Store.Models
    {
        public stock() : base("stock")
        { }
        public System.Data.DataTable display_stock()
        {
            String query = "exec display_Stock";
            return runquery(query);
        }
    }
}
