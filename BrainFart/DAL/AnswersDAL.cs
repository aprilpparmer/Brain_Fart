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
    }
}
