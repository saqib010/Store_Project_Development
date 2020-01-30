using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class order : Store.Models
    {
        public order() : base("OrderTable")
        { }
        public DataTable ord_detail(String id)
        {
            String query = "exec ord_detail "+id;
            return runquery(query);
        }
        public DataTable total_Amount(String id)
        {

            String query = "exec total_bill "+id;
            return runquery(query);

        }
    }
}
