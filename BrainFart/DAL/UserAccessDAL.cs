using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BrainFart.Model;
using BrainFart.DB;


namespace BrainFart.DAL
{
    /// <summary>
    /// User Access database access class
    /// </summary>
    public static class UserAccessDAL
    {
        /// <summary>
        /// Logins  User
        /// </summary>
        /// <param name="username">User name</param>
        /// <returns></returns>
        public static Users UserLogin(string username, Users LogonUser)
        {
            string SelectStatement = string.Empty;

            SelectStatement = "Select userID, username, password from [BrainFart].dbo.Users " +
            " where username like @UserName";

            SqlConnection connection = BrainFartConnection.GetConnection();
            SqlCommand selectCommand = new SqlCommand(SelectStatement, connection);
            selectCommand.Parameters.AddWithValue("@UserName", username);
            SqlDataReader reader = null;

            try
            {

                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {

                    LogonUser.UserID = (int)reader["userID"];
                    LogonUser.UserName = reader["userName"].ToString();
                    LogonUser.UserPassword = reader["passWord"].ToString();


                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            finally
            {
                if (connection != null) connection.Close();
                if (reader != null) reader.Close();
            }

            return LogonUser;
        }

        /// <summary>
        /// Calls the checkdatabase routine from DB layer
        /// </summary>
        /// <returns>True or false</returns>
        public static bool databaseExists()
        {
            return BrainFartConnection.CheckDatabase();
        }

    }


}
