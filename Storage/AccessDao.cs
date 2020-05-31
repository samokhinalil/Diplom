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
    public class AccessDao
    {
        private string connectionString;

        public AccessDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public Access CheckAccess(string login, string hashPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "CheckAccess";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@hashPassword", hashPassword);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                Employee employee =
                                    new Employee(int.Parse(reader["ID_сотрудника"].ToString()),
                                        reader["ФИО"].ToString(),
                                        reader["Паспорт"].ToString(),
                                        reader["Телефон"].ToString(),
                                        reader["Email"].ToString(),
                                        new Position(int.Parse(reader["ID_должности"].ToString()),
                                            reader["Название"].ToString()));

                                Role role = new Role(int.Parse(reader["ID_роли"].ToString()),
                                    reader["НазваниеРоли"].ToString());

                                Access access = new Access(employee, login, hashPassword,
                                    role);
                                return access;
                            }
                    }
                }
            }
            return null;
        }

        public void GrantAccessRights(Access access)
        {
            DeleteAccess(access);
            AddAccess(access);
        }

        private void DeleteAccess(Access access)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DeleteAccess";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", access.Employee.ID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void AddAccess(Access access)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddAccess";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", access.Employee.ID);
                    command.Parameters.AddWithValue("@login", access.Login);
                    command.Parameters.AddWithValue("@password", access.Password);
                    command.Parameters.AddWithValue("@roleId", access.Role.ID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
