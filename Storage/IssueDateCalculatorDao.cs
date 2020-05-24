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
    public class IssueDateCalculatorDao
    {
        private IssueListView calculatingIssue;
        private const int avgIssueCompletionTimeInDays = 7;
        private Complexity issueComplexity;
        private Priority issuePriority;
        private int employeeId;

        public IssueDateCalculatorDao(IssueListView issue, int employeeId)
        {
            calculatingIssue = issue;
            GetIssueComplexityByName(issue.ComplexityName);
            GetIssuePriorityByName(issue.PriorityName);
            this.employeeId = employeeId;
        }

        public DateTime CalculateIssueEndDate()
        {
            List<ActiveEmployeeIssue> activeIssues = GetActiveEmployeeIssues(employeeId);
            DateTime initialDateTime = DateTime.Now;
            double differrence = avgIssueCompletionTimeInDays + issueComplexity.ComplexityValue;

            if (activeIssues == null)
            {
                return DateTime.Now.AddDays(differrence);
            }
            else
            {
                //выборка задач выше по приоритету(чем выше приоритет, тем меньше значение)
                List<ActiveEmployeeIssue> higherPriorityIssues = activeIssues.Select(i => i)
                    .Where(i => i.IssuePriority.PriorityValue < issuePriority.PriorityValue).ToList();

                if(higherPriorityIssues.Count == 0)
                {
                    //пересчет времени выполнения задач ниже по приоритету
                    RecalculateEndDateLowerPriorityIssues();

                    return DateTime.Now.AddDays(differrence);
                }
                else
                {
                    DateTime max = higherPriorityIssues.Max(i => i.EndDate);
                    differrence += (max.Day + differrence / higherPriorityIssues.Count);
                    //пересчет времени выполнения задач ниже по приоритету
                    RecalculateEndDateLowerPriorityIssues();

                    return DateTime.Now.AddDays(differrence);
                }
            }
        }

        private void RecalculateEndDateLowerPriorityIssues()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "RecalculateEndDateLowerPriorityTasks";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@priorityValue", issuePriority.PriorityValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private Complexity GetIssueComplexityByName(string complexityName)
        {
            issueComplexity = new Complexity();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"select ID, Название, Значение from УровеньСложности where Название like '{complexityName}'";

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issueComplexity.ID = int.Parse(reader["ID"].ToString());
                                issueComplexity.ComplexityName = reader["Название"].ToString();
                                issueComplexity.ComplexityValue = int.Parse(reader["Значение"].ToString());
                            }
                    }
                }
            }
            return issueComplexity;
        }

        private Priority GetIssuePriorityByName(string priorityName)
        {
            issuePriority = new Priority();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"select ID_приоритета, НазваниеПриоритета, Значение from Приоритет where НазваниеПриоритета like '{priorityName}'";

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                issuePriority.ID = int.Parse(reader["ID_приоритета"].ToString());
                                issuePriority.PriorityName = reader["НазваниеПриоритета"].ToString();
                                issuePriority.PriorityValue = int.Parse(reader["Значение"].ToString());
                            }
                    }
                }
            }
            return issuePriority;
        }

        private static List<ActiveEmployeeIssue> GetActiveEmployeeIssues(int employeeId)
        {
            List<ActiveEmployeeIssue> activeEmployeeIssues = new List<ActiveEmployeeIssue>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeTasksWithEndDateOrderByPriority";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                activeEmployeeIssues.Add(new ActiveEmployeeIssue(
                                    int.Parse(reader["ID_задачи"].ToString()),
                                    new Priority(
                                    int.Parse(reader["ID_приоритета"].ToString()),
                                    reader["НазваниеПриоритета"].ToString(),
                                    int.Parse(reader["Значение"].ToString())),
                                    DateTime.Parse(
                                        reader["ПримернаяДатаВыполнения"].ToString())));

                            }
                    }
                }
            }

            return activeEmployeeIssues;
        }
    }
}
