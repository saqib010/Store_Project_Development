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
        public DataTable product_code_List()
        {
            return runquery("select Product_Code from Product");
        }
    }
}
