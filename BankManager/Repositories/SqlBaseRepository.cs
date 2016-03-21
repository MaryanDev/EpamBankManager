using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Repositories
{
    public abstract class SqlBaseRepository
    {
        private string _connectionString;

        public string ConnectionString { get { return _connectionString; } }

        public SqlBaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract bool SaveTable();
    }
}
