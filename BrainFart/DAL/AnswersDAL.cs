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
    class AnswersDAL
    {
        /// <summary>
        /// Gets a List of all Answers for a specific Question
        /// </summary>
        /// <returns>List<Questions> </returns>
        public static List<Answers> GetAllAnswerChoices(int questionID)
        {
            List<Answers> answerList = new List<Answers>();
            string selectStatement = "Select * FROM answers WHERE questionID = @questionID";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@questionID", questionID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Answers answer = new Answers();

                                answer.AnswerID = (Int32)reader["answerID"];
                                answer.QuestionID = (Int32)reader["questionID"];
                                answer.AnswerDescrip = reader["answerDescrip"].ToString().Trim();
                                answer.Correct = (Int32)reader["correct"];

                                answerList.Add(answer);
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
            return answerList;
        }


        /// <summary>
        /// Insert a Answer row to the Answers table
        /// </summary>
        /// <param name="answer">The input Answer row object</param>
        /// <returns>The AnswerID for the row inserted</returns>
        /// 
        public static int AddAnswer(Answers answer)
        {
            string insertStatement =
                "INSERT Answers " +
                    "(AnswerDescrip, QuestionID, Correct) " +
                "VALUES (@AnswerDescrip, @QuestionID, @Correct)";

            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@AnswerDescrip", answer.AnswerDescrip);
                        insertCommand.Parameters.AddWithValue("@QuestionID", answer.QuestionID);
                        insertCommand.Parameters.AddWithValue("@Correct", answer.Correct);

                        insertCommand.ExecuteNonQuery(); // Check for using statement use
                        string selectStatement =
                            "SELECT IDENT_CURRENT('Answers') FROM Answers"; // Check for backticks instead of single quotes
                        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                        {
                            int answerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                            return answerID;
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

    }
}