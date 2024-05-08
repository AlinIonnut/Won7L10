using Cursul_10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul_10.POS
{
    internal class ContactLessPOS: IContactLessPayment
    {
        public string TapCard()
        {
            return "Card tapped -> ";
        }

        public string ProcessPayment(double amount)
        {
            return $"Contactless payment processed for {amount}.";
        }
    }
}
