using System;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var M1 = new CashMachine();
            M1.Withdraw(4850);
            M1.ShowWithdraws();

            var M2 = new CashMachine();
            M2.Withdraw(100);
            M2.ShowWithdraws();
           

        }
    }
}
