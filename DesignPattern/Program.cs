using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction = new Transaction(ModeOfPayment.CreditCard);
            string result = transaction.MakePayment();
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }   
}
