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
    public class ProjectDao
    {
        private string connectionString;

        public ProjectDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public void Add(Project project)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddProject";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", project.ProjectName);
                    command.Parameters.AddWithValue("@startDate", project.StartDate);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    project.ID = resultID;
                }
            }
        }

        public void Edit(Project project)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditProject";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@projectID", project.ID);
                    command.Parameters.AddWithValue("@name", project.ProjectName);
                    command.Parameters.AddWithValue("@startDate", project.StartDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Project> SelectList()
        {
            List<Project> projects = new List<Project>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetProjects";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                projects.Add(new Project(
                                    int.Parse(reader["ID_проекта"].ToString()),
                                    reader["Название"].ToString(),
                                    DateTime.Parse(reader["ДатаНачала"].ToString())));
                            }
                    }
                }
            }
            return projects;
        }

        public List<Project> GetEmployeeProjects(int employeeId)
        {
            List<Project> projects = new List<Project>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeProjects";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                projects.Add(new Project(
                                    int.Parse(reader["ID_проекта"].ToString()),
                                    reader["Название"].ToString(),
                                    DateTime.Parse(reader["ДатаНачала"].ToString())));
                            }
                    }
                }
            }
            return projects;
        }
    }
}
