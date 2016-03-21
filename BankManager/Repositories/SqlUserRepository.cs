using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        #region Private fields
        private const string spGetUserQuery = "spGetUser";

        private readonly string _conectionString;
        #endregion

        #region Constructor
        public SqlUserRepository(string connectionString)
        {
            _conectionString = connectionString;
        }
        #endregion

        #region Public methods
        public User GetUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(_conectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(spGetUserQuery, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;
                        if(reader.Read())
                        {
                            user = new User();
                            user.Id = Convert.ToInt32(reader["Id"]);
                            user.FirstName = reader["FirstName"].ToString();
                            user.LastName = reader["LastName"].ToString();
                            user.Login = reader["Login"].ToString();
                            user.Disabled = Convert.ToBoolean(reader["Disabled"]);
                        }
                        return user;
                    }
                }
            }
        }
        #endregion
    }
}
