using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Store
{
    public static class DataBase
    {

        public static SqlConnection con;
        static DataBase()
        {
            try
            {
                con = new SqlConnection("Data Source=SPEED_DEVIL;Initial Catalog=Bakery;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                Console.Write("Couldn't connect\n" + ex.Message);
            }
        }

        public static SqlDataReader Query(string sqlQuery)
        {
            SqlCommand c = new SqlCommand(sqlQuery, con);
            return c.ExecuteReader();

        }

        public static IAsyncResult NonQuery(string sqlQuery)
        {
            SqlCommand c = new SqlCommand(sqlQuery, con);
            IAsyncResult result = c.BeginExecuteNonQuery();
            while (!result.IsCompleted)
            {
                System.Threading.Thread.Sleep(100);
            }
            c.EndExecuteNonQuery(result);

            return result;
        }
    }
}
