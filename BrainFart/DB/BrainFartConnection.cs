﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BrainFart.DB
{
    /// <summary>
    /// A utility class that helps establish a connection
    /// to the BrainFart database for the BrainFart application
    /// </summary>
    public static class BrainFartConnection
    {
        /// <summary>
        /// Get a connection to the BrainFart database
        /// </summary>
        /// <returns>an SqlConnection object</returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            try
            {
                string connectionString =
                    "Data Source=localhost;Initial Catalog=BrainFart;" +
                    "Integrated Security=True";
                connection = new SqlConnection(connectionString);
            }
           catch (Exception ex)
            {
                throw ex;
            }
                return connection;
        }
        /// <summary>
        /// Check if database exists. This is useful if the database was removed for some reason and the application crashes.
        /// </summary>
        /// <returns></returns>
        public static bool CheckDatabase()
        {
            bool databaseExists = false;
            string connectionString =
                "Data Source=localhost;Initial Catalog=master;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            String statement = "SELECT name FROM sys.databases WHERE name = N'BrainFart'";
            SqlCommand cmd = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                string dbname = (string)cmd.ExecuteScalar();


                if (dbname != null && dbname.Trim().ToUpper() == "BRAINFART")
                {
                    databaseExists = true;
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
                connection.Close();
            }

            return databaseExists;
        }
    }
}

