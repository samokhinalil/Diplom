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
    public class PositionDao
    {
        private string connectionString;

        public PositionDao(string connectionStringName)
        {
            connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public  void Add(Position position)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddPosition";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", position.PositionName);

                    var returnParameter = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int resultID = (int)returnParameter.Value;
                    connection.Close();

                    position.ID = resultID;
                }
            }
        }

        public  void Edit(Position position)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "EditPosition";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", position.ID);
                    command.Parameters.AddWithValue("@name", position.PositionName);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public  List<Position> SelectList()
        {
            List<Position> positions = new List<Position>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetPositions";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            while (reader.Read())
                            {
                                positions.Add(new Position(reader.GetInt32(0), reader.GetString(1)));
                            }
                    }
                }
            }

            return positions;
        }
    }
}
