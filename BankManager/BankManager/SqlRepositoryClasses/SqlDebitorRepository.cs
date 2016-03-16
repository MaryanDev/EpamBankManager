using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    class SqlDebitorRepository : IDebitorRepositary
    {
        private readonly string _connectionString;

        public SqlDebitorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Debitor> GetDebitors(string firstName, string lastName, string phone)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "sp_GetDebitors";
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@searchedFName", firstName);
                    command.Parameters.AddWithValue("@searchedLName", lastName);
                    command.Parameters.AddWithValue("@searchedPhone", phone);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Debitor> resultList = new List<Debitor>();

                        while(reader.Read())
                        {
                            resultList.Add(new Debitor
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString()
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public IEnumerable<Debitor> GetDebitors()
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "sp_GetDebitors";
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Debitor> resultList = new List<Debitor>();

                        while (reader.Read())
                        {
                            resultList.Add(new Debitor
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString()
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public int AddDebitor(Debitor newDebitor)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_AddNewDebitor", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@firstName", newDebitor.FirstName);
                    command.Parameters.AddWithValue("@lastName", newDebitor.LastName);
                    command.Parameters.AddWithValue("@phoneNumber", newDebitor.PhoneNumber);

                    SqlParameter newId = new SqlParameter("@newDebitorId", System.Data.SqlDbType.Int);
                    newId.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(newId);

                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@newDebitorId"].Value.ToString());
                }
            }
        }
    }
}
