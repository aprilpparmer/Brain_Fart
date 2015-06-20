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
    class QuestionsDAL
    {
        /// <summary>
        /// Gets a List of all questions
        /// </summary>
        /// <returns>List<Questions> </returns>
        public static List<Questions> GetAllQuestions()
        {
            List<Questions> questionList = new List<Questions>();
            string selectStatement = "Select * FROM questions";

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
                                Questions question = new Questions();

                                question.QuestionID = (Int32)reader["questionID"];
                                question.QuestionDescrip = reader["questionDescrip"].ToString().Trim();
                                question.CategoryID = (Int32)reader["categoryID"];
                                question.DifficultyID = (Int32)reader["difficultyID"];

                                questionList.Add(question);
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
            return questionList;
        }
    }
}
