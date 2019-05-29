using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datalayer
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            string ConString = "Data Source=SoftDev;" + "Initial Catalog=MMABooks;" + "Integrated security=true;";
            connection.ConnectionString = ConString;
            connection.Open();
            
            return connection;
        }
    }
}
