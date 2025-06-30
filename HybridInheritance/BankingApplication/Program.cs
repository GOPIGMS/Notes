using System;

namespace BankingApplication;

class Program
{
    public static void Main(string[] args)
    {
        //looping two times for creating two objects
        for (int i = 0; i < 2; i++)
        {
            //creating the properties
            Console.WriteLine($"Getting the Details of Account {i + 1}");
            //getting the permanent employee Details
            Console.WriteLine($"Enter the AccountNumber");
            string accountNumber = Console.ReadLine();
            Console.WriteLine($"Enter the account Type");
            AccountTypeDetails accountType = Enum.Parse<AccountTypeDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the bank name");
            string bankName = Console.ReadLine();
            Console.WriteLine($"Enter the IFSC code ");
            string ifsc = Console.ReadLine();
            Console.WriteLine($"Enter the branch");
            string branch = Console.ReadLine();
            Console.WriteLine($"Enter the Balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the voter ID");
            string voterID = Console.ReadLine();
            Console.WriteLine($"Enter the Aadhar ID");
            long aadharID = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Enter the voter ID");
            string panNmuber = Console.ReadLine();
            Console.WriteLine($"Enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the genderDetails");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the data of birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the phone number");
            string phone = Console.ReadLine();
            Console.WriteLine($"Enter the mobile number");
            string mobile = Console.ReadLine();
            //creating the object of saving account
            SavingAccount savingAccountObject = new SavingAccount(accountNumber, accountType, bankName, ifsc, branch, balance, voterID, aadharID, panNmuber, name, gender, dob, phone, mobile);
            Console.WriteLine($"Enter the amount to deposit");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The amount after deposit {savingAccountObject.Deposit(depositAmount)}");
            Console.WriteLine($"Enter the amount to withdraw");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The amount after withdrawal {savingAccountObject.Withdraw(withdrawAmount)}");
            Console.WriteLine($"Enter the balance amount is : {savingAccountObject.BalanceCheck()}");



        }
    }
}