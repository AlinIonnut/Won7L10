using Cursul_10;
using Cursul_10.POS;

CashRegister cashRegister = new CashRegister();
ContactFullPOS contactFullPOS = new ContactFullPOS();
ContactLessPOS contactLessPOS = new ContactLessPOS();

Console.WriteLine(cashRegister.ScanProduct("Apple"));
Console.WriteLine(cashRegister.CashPayment(10));

Console.WriteLine(cashRegister.ContactFullPayment(20, contactFullPOS));
Console.WriteLine(cashRegister.ContactlessPayment(30, contactLessPOS));
