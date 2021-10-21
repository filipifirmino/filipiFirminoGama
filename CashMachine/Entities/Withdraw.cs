using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    public class Withdraw
    {
        public DateTime Moment { get; set; }
        public int WithdrawalAmount { get; set; }

        public Withdraw(DateTime moment, int withdrawalAmount)
        {
            Moment = moment;
            WithdrawalAmount = withdrawalAmount;
        }

    }
}
