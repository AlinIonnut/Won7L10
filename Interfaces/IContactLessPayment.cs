using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul_10.Interfaces
{
    internal interface IContactLessPayment
    {
        string TapCard();
        string ProcessPayment(double amount);
    }
}
