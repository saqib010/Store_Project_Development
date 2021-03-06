﻿using System;
using System.Collections.Generic;
using System.Data;
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
        
        public Boolean update_stock(int id, string quantity)
        {
            String query = "exec update_stock "+id+","+quantity;
            return exec_query(query);
        }

        public DataTable get_search_by_Id(String id)
        {
            return runquery("exec search_stock "+ id);
        } 
    }
}
