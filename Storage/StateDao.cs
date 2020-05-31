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
    public class StateDao
    {
        private string connectionString;

        public StateDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public void Add(State state)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddState";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", state.StateName);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    state.ID = resultID;
                }
            }
        }

        public void Edit(State state)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditState";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", state.ID);
                    command.Parameters.AddWithValue("@name", state.StateName);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<State> SelectList()
        {
            List<State> states = new List<State>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select ID_статуса, НазваниеСтатуса from Статус";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                states.Add(new State(reader.GetInt32(0), reader.GetString(1)));
                            }
                    }
                }
            }

            return states;
        }
    }
}
