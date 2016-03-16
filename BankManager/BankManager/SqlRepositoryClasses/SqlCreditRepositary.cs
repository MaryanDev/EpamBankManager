using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    class SqlCreditRepositary : ICreditRepositary
    {
        private readonly string _connectionString;

        public SqlCreditRepositary(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IEnumerable<Credit> GetCredits()
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetCredits", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Credit> resultList = new List<Credit>();
                        while (reader.Read())
                        {
                            resultList.Add(new Credit
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                DebitorId = int.Parse(reader["DebitorId"].ToString()),
                                OpenDate = DateTime.Parse(reader["OpenDate"].ToString()),
                                Amount = decimal.Parse(reader["Amount"].ToString()),
                                Balance = decimal.Parse(reader["Balance"].ToString()),
                                State = reader["State"].ToString()
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public IEnumerable<Credit> GetCredits(int debitorId)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetCredits", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@debitorId", debitorId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Credit> resultList = new List<Credit>();
                        while (reader.Read())
                        {
                            resultList.Add(new Credit
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                DebitorId = int.Parse(reader["DebitorId"].ToString()),
                                OpenDate = DateTime.Parse(reader["OpenDate"].ToString()),
                                Amount = decimal.Parse(reader["Amount"].ToString()),
                                Balance = decimal.Parse(reader["Balance"].ToString()),
                                State = reader["State"].ToString()
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public int OpenNewCredit(Credit newCredit)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_OpenNewCredit", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@debitorId", newCredit.DebitorId);
                    command.Parameters.AddWithValue("@openDate", newCredit.OpenDate);
                    command.Parameters.AddWithValue("@amount", newCredit.Amount);

                    SqlParameter newCreditId = new SqlParameter("@newCreditId", System.Data.SqlDbType.Int);
                    newCreditId.Direction = System.Data.ParameterDirection.Output;

                    command.Parameters.Add(newCreditId);

                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@newCreditId"].Value.ToString());
                }
            }
        }
    }
}
