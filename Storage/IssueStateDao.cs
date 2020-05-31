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
    public class IssueStateDao
    {
        private string connectionString;

        public IssueStateDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public State GetIssueCurrentState(int issueId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetTaskCurrentState";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taskId", issueId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                return new State(
                                    int.Parse(reader["ID_статуса"].ToString()),
                                    reader["НазваниеСтатуса"].ToString());
                            }
                    }
                }
            }
            return null;
        }
    }
}
