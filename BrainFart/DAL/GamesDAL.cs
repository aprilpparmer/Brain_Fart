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
    class GamesDAL
    {
        /// <summary>
        /// Insert a Game row to the Games table
        /// </summary>
        /// <param name="game">The input Game row object</param>
        /// <returns>The GamesID for the row inserted</returns>
        /// 
        public static int AddUserStats(Games game)
        {
            string insertStatement =
                "INSERT Games " +
                    "(UserID, Score, QuestionsMissed, QuestionsCorrect) " +
                "VALUES (@UserID, @Score, @QuestionsMissed, @QuestionsCorrect)";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserID", game.UserID);
                        insertCommand.Parameters.AddWithValue("@Score", game.Score);
                        insertCommand.Parameters.AddWithValue("@QuestionsMissed", game.QuestionsMissed);
                        insertCommand.Parameters.AddWithValue("@QuestionsCorrect", game.QuestionsCorrect);

                        insertCommand.ExecuteNonQuery(); // Check for using statement use
                        string selectStatement =
                            "SELECT IDENT_CURRENT('Games') FROM Games"; // Check for backticks instead of single quotes
                        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                        {
                            int gamesID = Convert.ToInt32(selectCommand.ExecuteScalar());
                            return gamesID;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static int userGamesPlayed(int userID)
        {
            string selectStatement = "Select COUNT(*) FROM games WHERE userID = @userID";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("userID", userID);
                        int games = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return games;
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
        }

        public static int userGamesAvg(int userID)
        {
            string selectStatement = "Select AVG(score) FROM games WHERE userID = @userID";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("userID", userID);
                        int games = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return games;
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
        }

        public static int userHighScore(int userID)
        {
            string selectStatement = "Select MAX(score) FROM games WHERE userID = @userID";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("userID", userID);
                        int games = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return games;
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
        }

        public static int userQuestionsMissed(int userID)
        {
            string selectStatement = "Select SUM(questionsMissed) FROM games WHERE userID = @userID";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("userID", userID);
                        int games = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return games;
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
        }

        public static int userQuestionsCorrect(int userID)
        {
            string selectStatement = "Select SUM(questionsCorrect) FROM games WHERE userID = @userID";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("userID", userID);
                        int games = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return games;
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
        }
    }
}


