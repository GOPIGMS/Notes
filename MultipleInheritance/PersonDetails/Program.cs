using System;

namespace PersonDetails;

class Program
{

    public static void Main(string[] args)
    {
        //global object
        RegisterPerson registerPersonObject = null;
        bool isLoopContinue = true;
        //showing the menu and getting the input details
        do
        {
            Console.WriteLine($"Enter the option to perform operation \n1.Register Person\n2.Show Details \n3.Exit");
            int option;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());


            }
            catch (Exception)
            {
                option = 0;
            }
            switch (option)
            {

                case 1:
                    {
                        //getting input for the properties
                        Console.WriteLine($"Enter the Date of Registration");
                        DateTime dateOfRegistration = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine($"Enter the Father Name");
                        string fatherName = Console.ReadLine();
                        Console.WriteLine($"Enter the Mother name");
                        string motherName = Console.ReadLine();
                        Console.WriteLine($"Enter the House Address");
                        string houseAddress = Console.ReadLine();
                        Console.WriteLine($"Enter the No of siblings");
                        int noOfSibling = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Name");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Enter the Gender Details");
                        GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
                        Console.WriteLine($"Enter the DOB");
                        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine($"Enter the phone number");
                        string phone = Console.ReadLine();
                        Console.WriteLine($"Enter the mobile number");
                        string mobile = Console.ReadLine();
                        Console.WriteLine($"Enter the marital status");
                        MaritalDetails maritalStatus = Enum.Parse<MaritalDetails>(Console.ReadLine(), true);
                        //assigning it to global object
                        registerPersonObject = new RegisterPerson(dateOfRegistration, fatherName, motherName, houseAddress, noOfSibling, name, gender, dob, phone, mobile, maritalStatus);
                        break;
                    }
                case 2:
                    {
                        //showing details
                        if (registerPersonObject != null)
                        {
                            Console.WriteLine(registerPersonObject.ShowInfo());
                        }
                        else
                        {
                            Console.WriteLine($"Please Enter Personal info first");
                        }

                        break;
                    }
                case 3:
                    {
                        //terminating loop
                        isLoopContinue = false;
                        break;
                    }
                default:
                    {
                        //getting invalid input
                        Console.WriteLine($"Invalid Input");
                        break;
                    }
            }

        } while (isLoopContinue);
    }
}