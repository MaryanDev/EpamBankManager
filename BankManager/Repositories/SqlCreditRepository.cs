using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace Repositories
{
    public class SqlCreditRepository : Repositories.SqlBaseRepository, ICreditRepository
    {
        #region Private fields
        private const string spGetCreditsQuery = "spGetCredits";
        private const string spOpenCreditQuery = "spOpenNewCredit";
        #endregion

        #region Constructor
        public SqlCreditRepository(string connectionString): base(connectionString)
        {
        }
        #endregion

        #region Public Methods
        public IEnumerable<Credit> GetCredits()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spGetCreditsQuery, connection))
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
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                DebitorId = Convert.ToInt32(reader["DebitorId"].ToString()),
                                OpenDate = Convert.ToDateTime(reader["OpenDate"].ToString()),
                                Amount = Convert.ToDecimal(reader["Amount"].ToString()),
                                Balance = Convert.ToDecimal(reader["Balance"].ToString()),
                                TypeId = Convert.ToInt32(reader["TypeId"].ToString()),
                                State = reader["State"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"].ToString())
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public IEnumerable<Credit> GetCredits(int debitorId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(spGetCreditsQuery, connection))
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
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                DebitorId = Convert.ToInt32(reader["DebitorId"].ToString()),
                                OpenDate = Convert.ToDateTime(reader["OpenDate"].ToString()),
                                Amount = Convert.ToDecimal(reader["Amount"].ToString()),
                                Balance = Convert.ToDecimal(reader["Balance"].ToString()),
                                TypeId = Convert.ToInt32(reader["TypeId"].ToString()),
                                State = reader["State"].ToString(),
                                UserId = Convert.ToInt32(reader["UserId"].ToString())
                            });
                        }

                        return resultList;
                    }
                }
            }
        }

        public int OpenNewCredit(Credit newCredit)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(spOpenCreditQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@debitorId", newCredit.DebitorId);
                    command.Parameters.AddWithValue("@openDate", newCredit.OpenDate);
                    command.Parameters.AddWithValue("@amount", newCredit.Amount);
                    command.Parameters.AddWithValue("@typeId", newCredit.TypeId);
                    command.Parameters.AddWithValue("@userId", newCredit.UserId);

                    SqlParameter newCreditId = new SqlParameter("@newCreditId", System.Data.SqlDbType.Int);
                    newCreditId.Direction = System.Data.ParameterDirection.Output;

                    command.Parameters.Add(newCreditId);

                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@newCreditId"].Value.ToString());
                }
            }
        }

        public override bool SaveTable()
        {
            IEnumerable<Credit> credits = GetCredits();
            try
            {
                using (StreamWriter writer = new StreamWriter(new FileStream("Credits.csv", FileMode.Create)))
                {
                    writer.WriteLine(@"""Id"";""DebitorId"";""OpenDate"";""Amount"";""Balance"";""State"";""UserId"";");
                    foreach (var credit in credits)
                    {
                        writer.WriteLine(@"""{0}"";""{1}"";""{2}"";""{3}"";""{4}"";""{5}"";""{6}"";", credit.Id, credit.DebitorId, credit.OpenDate, credit.Amount, credit.Balance, credit.State, credit.UserId);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
