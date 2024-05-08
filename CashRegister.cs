using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cursul_10.Interfaces;

namespace Cursul_10
{
    class CashRegister
    {
        public string ScanProduct(string productName)
        {
            return $"You scanned the product: {productName}.";
        }

        public string CashPayment(double amount)
        {
            string result = "Cash payment:";
            result += OpenSafe();
            result += InsertAmountInSafe(amount);
            result += CloseSafe();
            result += PrintReceipt();
            return result;
        }

        private static string OpenSafe()
        {
            return "Safe opened -> ";
        }
        private static string InsertAmountInSafe(double amount)
        {
            return $"Inserting {amount} into the safe -> ";
        }

        private static string CloseSafe()
        {
            return "Safe closed -> ";
        }

        private static string PrintReceipt()
        {
            return "Receipt printed.";
        }

        public string ContactFullPayment(double amount, IContactFullPayment pos)
        {
            string result = "Contact-full payment:";
            result += pos.InsertCard();
            result += pos.ProcessPayment(amount);
            result += pos.EjectCard();
            return result;
        }

        public string ContactlessPayment(double amount, IContactLessPayment pos)
        {
            string result = "Contactless payment:";
            result += pos.TapCard();
            result += pos.ProcessPayment(amount);
            return result;
        }

    }
}
