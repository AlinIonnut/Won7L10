using Cursul_10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul_10.POS
{
    class ContactFullPOS: IContactFullPayment
    {
        public string InsertCard()
        {
            return "Card inserted -> ";
        }

        public string ProcessPayment(double amount)
        {
            return $"Contact-full payment processed for {amount} -> ";
        }

        public string EjectCard()
        {
            return "Card ejected.";
        }
    }
}
