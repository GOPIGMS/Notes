using System;

namespace BankAccount;

class Program
{
    public static void Main(string[] args)
    {
        //wrapping the code with try catch to avoid unexpected program crash
        try
        {
            //creating the object and assigning it with null value
            PersonalInfo personalInfoObject = null;
            AccountInfo accountInfoObject = null;
            bool isLoopContinue = true;
            //creating loop to execute the statement untill the user exit
            do
            {
                Console.WriteLine($"Enter the option to perform operation \n1.CreatePersonalInfo and CreateStudent Info\n2.Show Account Info \n3.Deposit\n4.Withdraw\n5.ShowBalance\n6.Exit");
                int option;
                //wrapping the input getting with try catch
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());


                }
                catch (Exception)
                {
                    option = 0;
                }
                //switch statement to perform operation based on statement
                switch (option)
                {
                    case 1:
                        {
                            //Getting  the properties value for  creating the object
                            Console.WriteLine($"Enter the name");
                            string name = Console.ReadLine();
                            Console.WriteLine($"Enter the father name");
                            string fatherName = Console.ReadLine();
                            Console.WriteLine($"Enter the phone");
                            string phone = Console.ReadLine();
                            Console.WriteLine($"Enter the email");
                            string email = Console.ReadLine();
                            Console.WriteLine($"Enter the DOB");
                            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            Console.WriteLine($"Enter the Gender Details");
                            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
                            personalInfoObject = new PersonalInfo(name, fatherName, phone, email, dob, gender);
                            Console.WriteLine($"Enter the branch name");
                            string branch = Console.ReadLine();
                            Console.WriteLine($"Enter the IFSC code");
                            string ifscCode = Console.ReadLine();
                            Console.WriteLine($"Enter the Balance");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            accountInfoObject = new AccountInfo(name, fatherName, phone, email, dob, gender, branch, ifscCode, balance);
                            Console.WriteLine($"Account  created  and the account number is {accountInfoObject.AccountNumber}");

                            break;
                        }
                    case 2:
                        {
                            //displaying the details
                            if (accountInfoObject != null)
                            {
                                Console.WriteLine(accountInfoObject.ShowAccountInfo());
                            }
                            else
                            {
                                Console.WriteLine($"Please Enter Account info first");
                            }

                            break;
                        }
                    case 3:
                        {
                            //depositing the amount
                            if (accountInfoObject != null)
                            {
                                Console.WriteLine($"Enter the amount to deposit");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                accountInfoObject.Deposit(amount);
                            }
                            else
                            {
                                Console.WriteLine($"Please Enter Account info first");
                            }

                            break;
                        }
                    case 4:
                        {
                            //withdraw the amount
                            if (accountInfoObject != null)
                            {
                                Console.WriteLine($"Enter the amount to Withdraw");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                accountInfoObject.Withdraw(amount);
                            }
                            else
                            {
                                Console.WriteLine($"Please Enter Account info first");
                            }

                            break;
                        }
                    case 5:
                        {
                            //displaying the balance
                            if (accountInfoObject != null)
                            {
                                Console.WriteLine($"The current account balance is {accountInfoObject.Balance}");
                            }
                            else
                            {
                                Console.WriteLine($"Please Enter Account info first");
                            }

                            break;
                        }
                    case 6:
                        {
                            //exiting the loop
                            isLoopContinue = false;
                            break;
                        }
                    default:
                        {
                            //catching all the invalid input
                            Console.WriteLine($"Invalid Input");
                            break;
                        }
                }

            } while (isLoopContinue);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"The problem in the program is {ex.Message}");

        }
    }
}