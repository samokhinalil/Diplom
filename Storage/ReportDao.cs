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
        public static List<ReportSimpleEntity> GetPriorityReport()
        {
            List<ReportSimpleEntity> priorities = new List<ReportSimpleEntity>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "ReportPriorityCount";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                priorities.Add(new ReportSimpleEntity(reader.GetInt32(1),
                                    reader.GetString(0)));
                            }
                    }
                }
            }

            return priorities;
        }

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
    }
}
