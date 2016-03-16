using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    class Credit
    {
        public int Id { get; set; }

        public int DebitorId { get; set; }

        public DateTime OpenDate { get; set; }

        public decimal Amount { get; set; }

        public decimal Balance { get; set; }

        public string State { get; set; }
    }
}
