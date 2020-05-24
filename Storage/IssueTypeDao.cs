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
    public class IssueTypeDao
    {
        public static void Add(IssueType type)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddTaskType";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", type.TypeName);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    type.ID = resultID;
                }
            }
        }

        public static void Edit(IssueType type)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditTaskType";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", type.ID);
                    command.Parameters.AddWithValue("@name", type.TypeName);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<IssueType> SelectList()
        {
            List<IssueType> types = new List<IssueType>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select ID, НазваниеТипаЗадачи from ТипЗадачи";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                types.Add(new IssueType(reader.GetInt32(0), reader.GetString(1)));
                            }
                    }
                }
            }

            return types;
        }
    }
}
