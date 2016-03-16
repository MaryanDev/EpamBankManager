using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
    interface IDebitorRepositary
    {
        IEnumerable<Debitor> GetDebitors(string name, string lastName, string phone);

        IEnumerable<Debitor> GetDebitors();

        int AddDebitor(Debitor newDebitor);
    }
}
