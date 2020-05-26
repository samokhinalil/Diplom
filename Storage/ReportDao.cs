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
    public class ReportDao
    {
        public static List<SolvedTasksComplexityReport> GetSolvedTasksComplexityCountReportReport(DateTime fromDate, DateTime toDate)
        {
            List<SolvedTasksComplexityReport> list = new List<SolvedTasksComplexityReport>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ReportSolvedTasksComplexityCount";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                list.Add(new SolvedTasksComplexityReport(reader.GetString(0),
                                    reader.GetInt32(1)));
                            }
                    }
                }
            }

            return list;
        }

        public static List<StateEmployeeTasksCountReport> GetStateEmployeeTasksCountReport(
            int employeeId, DateTime fromDate, DateTime toDate)
        {
            List<StateEmployeeTasksCountReport> list = new List<StateEmployeeTasksCountReport>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ReportStateEmployeeTasksCount";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@dateFrom", fromDate);
                    command.Parameters.AddWithValue("@dateTo", toDate);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                list.Add(new StateEmployeeTasksCountReport(reader.GetString(0),
                                    reader.GetInt32(1)));
                            }
                    }
                }
            }

            return list;
        }

        public static List<StateEmployeeTasksCountReport> GetStateTasksCountReport(
            DateTime fromDate, DateTime toDate)
        {
            List<StateEmployeeTasksCountReport> list = new List<StateEmployeeTasksCountReport>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ReportStateAllTasksCount";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dateFrom", fromDate);
                    command.Parameters.AddWithValue("@dateTo", toDate);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                list.Add(new StateEmployeeTasksCountReport(reader.GetString(0),
                                    reader.GetInt32(1)));
                            }
                    }
                }
            }

            return list;
        }

        public static List<TimeOutTasksCountReport> GetTimeOutTasksCountReport(
            DateTime fromDate, DateTime toDate)
        {
            List<TimeOutTasksCountReport> list = new List<TimeOutTasksCountReport>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ReportTimeOutTasksCount";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dateFrom", fromDate);
                    command.Parameters.AddWithValue("@dateTo", toDate);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                list.Add(new TimeOutTasksCountReport(reader.GetString(0),
                                    reader.GetInt32(1)));
                            }
                    }
                }
            }

            return list;
        }

        public static List<TimeOutTasksInfoReport> GetTimeOutTasksInfoReport(
            DateTime fromDate, DateTime toDate)
        {
            List<TimeOutTasksInfoReport> list = new List<TimeOutTasksInfoReport>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ReportTimeOutTasksInfo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dateFrom", fromDate);
                    command.Parameters.AddWithValue("@dateTo", toDate);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                list.Add(new TimeOutTasksInfoReport(
                                    int.Parse(reader["TaskID"].ToString()),
                                    reader["EmployeeFullName"].ToString(),
                                    DateTime.Parse(reader["RequiredDate"].ToString()),
                                    reader["CurrentState"].ToString(),
                                    DateTime.Parse(reader["StateDate"].ToString()),
                                    int.Parse(reader["DateDifference"].ToString())));
                            }
                    }
                }
            }

            return list;
        }
    }
}
