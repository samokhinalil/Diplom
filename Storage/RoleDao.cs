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
    public class RoleDao
    {
        public static List<Role> SelectList()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection connection = new SqlConnection(ConnectionString.CurrentConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetRoles";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                roles.Add(new Role(reader.GetInt32(0), reader.GetString(1)));
                            }
                    }
                }
            }

            return roles;
        }
    }
}
