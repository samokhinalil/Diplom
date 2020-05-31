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
    public class IssueDao
    {
        private string connectionString;

        public IssueDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public int Add(string name, int priorityId,
            int complexityId, int typeId, int stateID,
            int projectId, string description,
            int employeeWhoAdded)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddTask";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@priorityId", priorityId);
                    command.Parameters.AddWithValue("@complexityId", complexityId);
                    command.Parameters.AddWithValue("@typeId", typeId);
                    command.Parameters.AddWithValue("@stateId", stateID);
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@employeeWhoAdded", employeeWhoAdded);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    return resultID;
                }
            }
        }

        public void Edit(int id, string name,
            int priorityId, int complexityId, int typeId,
            int projectId, string description,
            int newStateId,
            int employeeWhoChanged)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditTask";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@priorityId", priorityId);
                    command.Parameters.AddWithValue("@complexityId", complexityId);
                    command.Parameters.AddWithValue("@typeId", typeId);
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@newStateId", newStateId);
                    command.Parameters.AddWithValue("@employeeWhoChanged", employeeWhoChanged);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IssueView GetByID(int id)
        {
            IssueView issue = new IssueView();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetTaskByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taskId", id);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issue = new IssueView(
                                    id,
                                    reader["Название"].ToString(),
                                    int.Parse(reader["Приоритет"].ToString()),
                                    int.Parse(reader["УровеньСложности"].ToString()),
                                    int.Parse(reader["ТипЗадачи"].ToString()),
                                    int.Parse(reader["Проект"].ToString()),
                                    reader["Описание"].ToString(),
                                    int.Parse(reader["Статус"].ToString()),
                                    reader["НазваниеСтатуса"].ToString());
                            }
                    }
                }
            }

            issue.SubIssues = GetSubIssues(id);

            return issue;
        }

        public List<IssueView> GetSubIssues(int taskId)
        {
            List<IssueView> subissues = new List<IssueView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetSubTasks";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taskId", taskId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                subissues.Add(new IssueView(
                                    int.Parse(reader["Подзадача"].ToString()),
                                    reader["Название"].ToString(),
                                    int.Parse(reader["Приоритет"].ToString()),
                                    int.Parse(reader["УровеньСложности"].ToString()),
                                    int.Parse(reader["ТипЗадачи"].ToString()),
                                    int.Parse(reader["Проект"].ToString()),
                                    reader["Описание"].ToString(),
                                    int.Parse(reader["Статус"].ToString()),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return subissues;
        }

        public List<IssueListView> SelectList()
        {
            List<IssueListView> issuesView = new List<IssueListView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetTasks";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuesView.Add(new IssueListView(
                                    int.Parse(reader["ID_задачи"].ToString()),
                                    reader["НазваниеЗадачи"].ToString(),
                                    reader["НазваниеПриоритета"].ToString(),
                                    reader["НазваниеУровняСложности"].ToString(),
                                    reader["НазваниеТипаЗадачи"].ToString(),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return issuesView;
        }

        public List<IssueListView> GetProjectIssues(int projectId)
        {
            List<IssueListView> issuesView = new List<IssueListView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetProjectTasks";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@projectId", projectId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuesView.Add(new IssueListView(
                                    int.Parse(reader["ID_задачи"].ToString()),
                                    reader["НазваниеЗадачи"].ToString(),
                                    reader["НазваниеПриоритета"].ToString(),
                                    reader["НазваниеУровняСложности"].ToString(),
                                    reader["НазваниеТипаЗадачи"].ToString(),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return issuesView;
        }

        public List<IssueListView> GetEmployeeIssues(int employeeId, int projectId)
        {
            List<IssueListView> issuesView = new List<IssueListView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeTasks";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@projectId", projectId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuesView.Add(new IssueListView(
                                    int.Parse(reader["Задача"].ToString()),
                                    reader["НазваниеЗадачи"].ToString(),
                                    reader["НазваниеПриоритета"].ToString(),
                                    reader["НазваниеУровняСложности"].ToString(),
                                    reader["НазваниеТипаЗадачи"].ToString(),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return issuesView;
        }

        public List<IssueListView> GetEmployeeOpenIssues(int employeeId, int projectId)
        {
            List<IssueListView> issuesView = new List<IssueListView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeOpenTasks";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@projectId", projectId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuesView.Add(new IssueListView(
                                    int.Parse(reader["Задача"].ToString()),
                                    reader["НазваниеЗадачи"].ToString(),
                                    reader["НазваниеПриоритета"].ToString(),
                                    reader["НазваниеУровняСложности"].ToString(),
                                    reader["НазваниеТипаЗадачи"].ToString(),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return issuesView;
        }

        public List<IssueListView> GetProjectOpenIssues(int projectId)
        {
            List<IssueListView> issuesView = new List<IssueListView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetProjectOpenTasks";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@projectId", projectId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuesView.Add(new IssueListView(
                                    int.Parse(reader["ID_задачи"].ToString()),
                                    reader["НазваниеЗадачи"].ToString(),
                                    reader["НазваниеПриоритета"].ToString(),
                                    reader["НазваниеУровняСложности"].ToString(),
                                    reader["НазваниеТипаЗадачи"].ToString(),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return issuesView;
        }

        public List<IssueListView> GetEmployeeExecutedIssues(int employeeId, int projectId)
        {
            List<IssueListView> issuesView = new List<IssueListView>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeExecutedTasks";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@projectId", projectId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuesView.Add(new IssueListView(
                                    int.Parse(reader["Задача"].ToString()),
                                    reader["НазваниеЗадачи"].ToString(),
                                    reader["НазваниеПриоритета"].ToString(),
                                    reader["НазваниеУровняСложности"].ToString(),
                                    reader["НазваниеТипаЗадачи"].ToString(),
                                    reader["НазваниеСтатуса"].ToString()));
                            }
                    }
                }
            }
            return issuesView;
        }

        public void ChangeIssueState(int issueID, int stateID, int employeeWhoChanged)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ChangeTaskState";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taskId", issueID);
                    command.Parameters.AddWithValue("@stateID", stateID);
                    command.Parameters.AddWithValue("@employeeWhoChanged", employeeWhoChanged);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CloseExecutedIssue(int employeeId, int issueId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "CloseTask";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@taskId", issueId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CloseAllExecutedIssues(int employeeId, List<IssueListView> issues)
        {
            DataTable issuesIds = new DataTable();
            issuesIds.Columns.Add("subTaskId", typeof(int));
            foreach (var issue in issues)
            {
                issuesIds.Rows.Add(issue.ID);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "CloseAllExecutedTask";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    var tableParameter = command.Parameters.AddWithValue("@tasksIds", issuesIds);
                    tableParameter.SqlDbType = SqlDbType.Structured;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSubIssue(int subIssueId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DeleteSubTask";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@subTaskId", subIssueId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertIssueSubIssues(int taskId, List<IssueView> subIssues)
        {
            DataTable subissuesIds = new DataTable();
            subissuesIds.Columns.Add("subTaskId", typeof(int));
            foreach (var subIssue in subIssues)
            {
                subissuesIds.Rows.Add(subIssue.ID);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "InsertTaskSubTasks";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@taskId", taskId);
                    var tableParameter = command.Parameters.AddWithValue("@subTaskIds", subissuesIds);
                    tableParameter.SqlDbType = SqlDbType.Structured;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AppointIssueToEmployee(int taskId, int executorId,
            int appointerEmployeeId, DateTime endDate)
        {
            List<IssueView> subIssues = GetSubIssues(taskId);

            DataTable subissuesIds = new DataTable();
            subissuesIds.Columns.Add("subTaskId", typeof(int));
            foreach (var subIssue in subIssues)
            {
                subissuesIds.Rows.Add(subIssue.ID);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AppointTaskToEmployee";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taskId", taskId);
                    command.Parameters.AddWithValue("@executorId", executorId);
                    command.Parameters.AddWithValue("@employeeIdWhoAppoint", appointerEmployeeId);
                    command.Parameters.AddWithValue("@endDate", endDate);
                    var tableParameter = command.Parameters.AddWithValue("@subTaskIds", subissuesIds);
                    tableParameter.SqlDbType = SqlDbType.Structured;


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<IssueDetailInfo> GetIssueDetailInfo(int issueId)
        {
            List<IssueDetailInfo> issue = new List<IssueDetailInfo>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetDetailTaskInfo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taskId", issueId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issue.Add(new IssueDetailInfo(
                                    int.Parse(reader["IssueId"].ToString()),
                                    reader["IssueName"].ToString(),
                                    reader["PriorityName"].ToString(),
                                    reader["ComplexityName"].ToString(),
                                    reader["TypeName"].ToString(),
                                    reader["ExecutorName"].ToString(),
                                    reader["OwnerName"].ToString(),
                                    DateTime.Parse(reader["StartDate"].ToString()),
                                    DateTime.Parse(reader["EndDate"].ToString())));
                            }
                    }
                }
            }
            return issue;
        }
    }
}
