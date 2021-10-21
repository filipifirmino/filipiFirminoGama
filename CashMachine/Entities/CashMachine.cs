using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class CashMachine
    {
        public List<Withdraw> WithdrawalsMade { get; set; } = new List<Withdraw>();

        
        private List<int> AvailableBills = new() { 100, 50, 20, 10, 5 };
        private List<string> BillsResult = new List<string>();
        private bool WithDrawIsValid = false;

        public void Withdraw(int amount)
        {
            if (amount == 0)
            {
                Console.WriteLine("Valor invalido");
            }
            else
            {
                CountBills(amount);
                if (WithDrawIsValid)
                {
                    var Withdraw = new Withdraw(DateTime.Now, amount);
                    WithdrawalsMade.Add(Withdraw);
                    Console.WriteLine("Seu saque foi realizado com sucesso, em notas de : \n");
                    foreach (string x in BillsResult)
                    {
                        Console.WriteLine(x);
                    }
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }
            }
        }

        public void ShowWithdraws()
        {
            foreach (Withdraw wit in WithdrawalsMade)
            {
                Console.WriteLine($"Saque realizado na dia: {wit.Moment} no valor de: R${wit.WithdrawalAmount.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }


        private void CountBills(int amount)
        {
            foreach (int x in AvailableBills)
            {
                int result = amount / x;
                BillsResult.Add($"{result} notas de {x}");
                amount -= (result * x);
            }
            if (amount == 0)
            {
                WithDrawIsValid = true;
            }
        }
    }
}
