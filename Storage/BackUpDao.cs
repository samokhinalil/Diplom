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
    public class BackUpDao
    {
        private string connectionString;

        public BackUpDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public void CreateBackUp(string filePath)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "CreateBackUp";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fileName", filePath);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RestoreDataBase(string fileName)
        {

        }
    }
}
