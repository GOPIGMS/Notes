using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class AccountInfo : PersonalInfo
    {
        //creating the properties for the accountInfo
        private static int s_accountNumber = 0;
        private static double s_balance;
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance
        {
            get
            {
                return s_balance;
            }
        }
        //creating the default constructor
        public AccountInfo() { }
        //creating the parameterized constructor and setting the value and passing to  datas to the base class
        public AccountInfo(string name, string fatherName, string phone, string mail, DateTime dob, GenderDetails gender, string branchName, string ifsccode, double balance) : base(name, fatherName, phone, mail, dob, gender)
        {
            AccountNumber = ++s_accountNumber;
            BranchName = branchName;
            IFSCCode = ifsccode;
            s_balance = balance;
        }
        //showing the account details
        public string ShowAccountInfo()
        {
            return $"AccountNumber :{AccountNumber}, BranchName :{BranchName}, IFSCCode :{IFSCCode}, Balance :{Balance} {DisplayPersonalInfo()}";
        }
        //deposit the amount
        public void Deposit(double amount)
        {
            s_balance += amount > 0 ? amount : 0;
            ShowBalance();
        }
        //withdraw the amount
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Insuffcient Balance");

                return;
            }
            s_balance -= amount;
            ShowBalance();
        }
        //show the balance
        public void ShowBalance()
        {
            Console.WriteLine($"The current Balance is {Balance}");
        }
    }
}