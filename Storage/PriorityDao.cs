using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class PriorityDao
    {
        private string connectionString;

        public PriorityDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public void Add(Priority priority)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddPriority";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", priority.PriorityName);
                    command.Parameters.AddWithValue("@value", priority.PriorityValue);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    priority.ID = resultID;
                }
            }
        }

        public void Edit(Priority priority)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditPriority";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", priority.ID);
                    command.Parameters.AddWithValue("@name", priority.PriorityName);
                    command.Parameters.AddWithValue("@value", priority.PriorityValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Priority> SelectList()
        {
            List<Priority> priorities = new List<Priority>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select ID_приоритета, НазваниеПриоритета, Значение from Приоритет";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                priorities.Add(new Priority(reader.GetInt32(0),
                                    reader.GetString(1), reader.GetInt32(2)));
                            }
                    }
                }
            }

            return priorities;
        }
    }
}
