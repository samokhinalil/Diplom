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
    public class IssueStateDao
    {
        public static State GetIssueCurrentState(int issueId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
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
