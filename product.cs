using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class product: Store.Models
    {
        public product() : base("Product")
        { }
       /* public DataTable Prod_ID_List()
        {
            String query = "select Product_ID from Product";
            return runquery(query);
        }**/
    }
}
