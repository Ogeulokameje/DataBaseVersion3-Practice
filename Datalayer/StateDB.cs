using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLayer;

namespace Datalayer
{
    public class StateDB
    {
        public static List<State> GetStates()
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            List<State> results = new List<State>();
            try
            {                
                string sql = "SELECT StateCode, StateName FROM States";
                SqlCommand command = new SqlCommand(sql, connection);
                
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    State s = new State();
                    s.StateCode = reader["StateCode"].ToString();
                    s.StateName = reader["StateName"].ToString();
                    results.Add(s);
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }

          return results;


        }
    }
}
