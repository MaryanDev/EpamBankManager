using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    class SqlPaymentRepositary //: IPaymentRepositary
    {
        private readonly string _connectionString;

        public SqlPaymentRepositary(string connectionString)
        {
            _connectionString = connectionString;
        }

        //public IEnumerable<Payment> GetPayments()
        //{

        //}
    }
}
