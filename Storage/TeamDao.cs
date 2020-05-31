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
    public class TeamDao
    {
        private string connectionString;

        public TeamDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddEmployeeToProjectTeam";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmployeeFromProject(int projectId, int employeeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DeleteEmployeeFromProjectTeam";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Employee> GetProjectTeam(int projectId)
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeesFromProject";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@projectId", projectId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                Position position = new Position(reader.GetInt32(5), reader.GetString(6));
                                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetString(4), position);
                                employees.Add(employee);
                            }
                    }
                }
            }
            return employees;
        }
    }
}
