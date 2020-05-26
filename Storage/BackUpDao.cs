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
    public class BackUpDao
    {
        public static void CreateBackUp(string filePath)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
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

        public static void RestoreDataBase(string fileName)
        {

        }
    }
}
