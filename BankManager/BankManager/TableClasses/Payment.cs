using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    class Payment
    {
        public int Id { get; set; }

        public int CreditId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }
    }
}
