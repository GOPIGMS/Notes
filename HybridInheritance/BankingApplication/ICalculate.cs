using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public interface ICalculate
    {
        //defining properties
        double Deposit(double amount);
        double Withdraw(double amount);
        double BalanceCheck();
    }
}