using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace ToyCorner.Code
{
    public class Connections
    {
        // Hosted Database
        public static SqlConnection Conn_Host4ASP(string password)
        {
            var conn = new SqlConnection("Data Source = icebreak.host4asp.net,1431; Initial Catalog = atxtexme_db1; user id = atxtexme_admin; Password = " + password);
            return (conn);
        }

        // Local Database
        public static SqlConnection Conn_Local()
        {
            var conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ToyCorner;Integrated Security=True;MultipleActiveResultSets=True");
            return (conn);
        }


    }
}