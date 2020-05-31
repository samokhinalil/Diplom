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
    public class EmployeeDao
    {
        private string connectionString;

        public EmployeeDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public void Add(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "AddEmployee";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeName", employee.FullName);
                    command.Parameters.AddWithValue("@passport", employee.Passport);
                    command.Parameters.AddWithValue("@phoneNumber", employee.Phone);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@positionId", employee.Position.ID);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    employee.ID = resultID;
                }
            }
        }

        public void Edit(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "EditEmployee";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeId", employee.ID);
                    command.Parameters.AddWithValue("@employeeName", employee.FullName);
                    command.Parameters.AddWithValue("@passport", employee.Passport);
                    command.Parameters.AddWithValue("@phoneNumber", employee.Phone);
                    command.Parameters.AddWithValue("@email", employee.Email);
                    command.Parameters.AddWithValue("@positionId", employee.Position.ID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Employee GetByID(int index)
        {
            Employee employee = new Employee();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployeeByID";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", index);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                Position position = new Position(reader.GetInt32(5), reader.GetString(6));
                                employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetString(4), position);
                            }
                    }
                }
            }
            return employee;
        }

        public List<Employee> SelectList()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetEmployees";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                Position position = new Position(reader.GetInt32(5), reader.GetString(6));
                                Employee employee = new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                    reader.GetString(3), reader.GetString(4), position);
                                employees.Add(employee);
                            }
                    }
                }
            }
            return employees;
        }
    }
}
