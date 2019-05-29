using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLayer;

namespace Datalayer
{
    public class CustomerDB
    {
        public static Customer GetCustomer(int ID)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            Customer s = new Customer();
            try
            {
                string sql = "SELECT CustomerID, Name, Address,City,State,ZipCode FROM Customers WHERE CustomerID=" + ID;
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())

                {
                    s.Name = reader["Name"].ToString();
                    s.Address = reader["Address"].ToString();
                    s.City = reader["City"].ToString();
                    s.State = reader["State"].ToString();
                    s.ZipCode = reader["ZipCode"].ToString();
                    s.CustomerID = Convert.ToInt32(reader["CustomerID"].ToString());

                }
            }
            catch(Exception ex)
            {
                int i = 0;
            }
            finally
            {
                connection.Close();
            }
            return s;
            
        }
        public static int AddCustomer(string Name, string Address,string City, string State, string ZipCode)
        {
            string sql = "INSERT INTO Customers" +
                         " (Name, Address, City, State, ZipCode) " +
                         "VALUES" +
                         " (@Name, @Address, @City, @State, @ZipCode) ";
            SqlConnection connection = Datalayer.MMABooksDB.GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@City", City);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@State", State);
            command.Parameters.AddWithValue("@ZipCode", ZipCode);
             

            
            int c = command.ExecuteNonQuery();
            return c;
        }
    }
   
    
}

