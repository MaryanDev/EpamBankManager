using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    interface ICreditRepositary
    {
        IEnumerable<Credit> GetCredits();

        IEnumerable<Credit> GetCredits(int debitorId);

        int OpenNewCredit(Credit newCredit);
    }
}
