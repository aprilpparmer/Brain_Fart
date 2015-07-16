using BrainFart.DB;
using BrainFart.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.DAL
{
    public static class UsersDAL
    {

        /// <summary>
        /// Adds user to user table when new user registers
        /// </summary>
        /// <param name="user"></param>
        public static void AddUser(Users user)
        {
            string userName;
            SqlConnection connection = BrainFartConnection.GetConnection();
            string insertStatement =
                "Insert into users " +
                "(username, password) " +
                "Values (@UserName, @userPassword)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@UserName", user.UserName);
            insertCommand.Parameters.AddWithValue("@UserPassword", user.UserPassword);
            userName = user.UserName;
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('Users') FROM Users";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int userID = Convert.ToInt32(selectCommand.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
