using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class ComplexityDao
    {
        public static void Add(Complexity complexity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddComplexity";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", complexity.ComplexityName);
                    command.Parameters.AddWithValue("@value", complexity.ComplexityValue);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    complexity.ID = resultID;
                }
            }
        }

        public static void Edit(Complexity complexity)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditComplexity";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", complexity.ID);
                    command.Parameters.AddWithValue("@name", complexity.ComplexityName);
                    command.Parameters.AddWithValue("@value", complexity.ComplexityValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Complexity> SelectList()
        {
            List<Complexity> complexities = new List<Complexity>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select ID, Название, Значение from УровеньСложности";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                complexities.Add(new Complexity(reader.GetInt32(0),
                                    reader.GetString(1), reader.GetInt32(2)));
                            }
                    }
                }
            }

            return complexities;
        }
    }
}
