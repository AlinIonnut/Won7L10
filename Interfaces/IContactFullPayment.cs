using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul_10.Interfaces
{
    internal interface IContactFullPayment
    {
        string InsertCard();
        string ProcessPayment(double amount);
        string EjectCard();
    }
}
