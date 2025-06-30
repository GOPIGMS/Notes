using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
    {
        //private fields of saving Account
        private double _balance = 0;
        public string AccountNumber { get; set; }
        public AccountTypeDetails AccountType { get; set; }
        //displaying the properties of interface
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        //constructors
        //default Constructor
        public SavingAccount() { }
        public SavingAccount(string accountNumber, AccountTypeDetails accountType, string bankName, string ifsc, string branch, double balance, string voterID, long aadharID, string panNumber, string name, GenderDetails gender, DateTime dob, string phone, string mobile) : base(voterID, aadharID, panNumber, name, gender, dob, phone, mobile)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            BankName = bankName;
            IFSC = ifsc;
            Branch = branch;
            _balance = balance > 0 ? balance : 0;
        }
        //methods of the class
        public double Deposit(double amount)
        {
            _balance += amount > 0 ? amount : 0;
            return Balance;

        }
        //withdraw method
        public double Withdraw(double amount)
        {
            _balance -= amount;
            return Balance;
        }
        //check balance
        public double BalanceCheck()
        {
            return Balance;
        }
    }
}