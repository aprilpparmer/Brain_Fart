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
    class CategoriesDAL
    {
        /// <summary>
        /// Gets a List of all categories
        /// </summary>
        /// <returns>List<Categories> </returns>
        public static List<Categories> GetAllCategories()
        {
            List<Categories> categoryList = new List<Categories>();
            string selectStatement = "Select * FROM categories";

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
                                Categories category = new Categories();
                                category.CategoryID = (Int32)reader["categoryID"];
                                category.CategoryDescrip = reader["categoryDescrip"].ToString().Trim();

                                categoryList.Add(category);
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
            return categoryList;
        }
    }
}