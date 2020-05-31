using EntityLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class ConnectionStringController
    {
        public ConnectionString ConnectionString
        {
            get
            {
                var parts = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString
                    .Split(';');
                return new ConnectionString(parts[0].Trim(),
                    parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), parts[4].Trim());
            }
        }

        public bool CheckConnection(ConnectionString connectionString, out string message)
        {
            StringBuilder resultSb = new StringBuilder(200);
            SqlConnection connection = new SqlConnection(connectionString.ToString());

            resultSb.Append($"Строка соединения:{connectionString}\n");

            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    resultSb.Append($"Сообщение: {error.Message}\n");
                    resultSb.Append($"Код ошибки: {error.Number}\n");
                }
                message = resultSb.ToString();
                return false;
            }
            finally
            {
                connection.Close();
            }

            message = resultSb.ToString();
            return true;
        }
    }
}
