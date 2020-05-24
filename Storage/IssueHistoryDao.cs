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
    public class IssueHistoryDao
    {
        public static List<IssueHistory> GetEmployeeIssuesHistory(int employeeId)
        {
            List<IssueHistory> history = new List<IssueHistory>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeTasksHistory";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                history.Add(new IssueHistory(
                                    int.Parse(reader["ID_задачи"].ToString()),
                                    reader["Название"].ToString(),
                                    reader["НазваниеСтатуса"].ToString(),
                                    DateTime.Parse(reader["Дата"].ToString())));
                            }
                    }
                }
            }
            return history;
        }
    }
}
