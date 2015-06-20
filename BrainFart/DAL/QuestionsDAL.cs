﻿using BrainFart.DB;
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

        /// <summary>
        /// Insert a Question row to the Questions table
        /// </summary>
        /// <param name="question">The input Question row object</param>
        /// <returns>The QuestionID for the row inserted</returns>
        /// 
        public static int AddQuestion(Questions question)
        {
            string insertStatement =
                "INSERT Questions " +
                    "(QuestionDescrip, CategoryID, DifficultyID) " +
                "VALUES (@QuestionDescrip, @CategoryID, @DifficultyID)";
               
            try
            {
                using (SqlConnection connection = BrainFartConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@QuestionDescrip", question.QuestionDescrip);
                        insertCommand.Parameters.AddWithValue("@CategoryID", question.CategoryID);
                        insertCommand.Parameters.AddWithValue("@DifficultyID", question.DifficultyID);
 
                        insertCommand.ExecuteNonQuery(); // Check for using statement use
                        string selectStatement =
                            "SELECT IDENT_CURRENT('Questions') FROM Questions"; // Check for backticks instead of single quotes
                        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                        {
                            int questionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                            return questionID;
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
