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
    class DifficultiesDAL
    {
        /// <summary>
        /// Gets a List of all difficulties
        /// </summary>
        /// <returns>List<Difficulties> </returns>
        public static List<Difficulties> GetAllDifficulties()
        {
            List<Difficulties> difficultyList = new List<Difficulties>();
            string selectStatement = "Select * FROM difficulties";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Difficulties difficulty = new Difficulties();
                                difficulty.DifficultyID = (Int32)reader["difficultyID"];
                                difficulty.DifficultyDescrip = reader["difficultyDescrip"].ToString().Trim();

                                difficultyList.Add(difficulty);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return difficultyList;
        }
    }
}