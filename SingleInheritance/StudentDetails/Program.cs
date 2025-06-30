using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Transactions;

namespace StudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        //creating the object and initializing it as null
        PersonalInfo personalInfoObject = null;
        StudentInfo studentInfoObject = null;
        bool isLoopContinue = true;
        //do while to excute the process untill the user exit
        do
        {
            Console.WriteLine($"Enter the option to perform operation \n1.CreatePersonalInfo\n2.CreatePersonalInfo and CreateStudent Info\n3.DisplayDetails\n4.Exit");
            int option;
            //wrapping the input getting in try catch to handle the error
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
                        //creating the object with user entered values for personal info
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
                        Console.WriteLine($"Personal info object created ");
                        break;
                    }
                case 2:
                    {
                        //creating the object with user entered values for student Info
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
                        Console.WriteLine($"Enter the Student Standard");
                        string standard = Console.ReadLine();
                        Console.WriteLine($"Enter the branch");
                        string branch = Console.ReadLine();
                        Console.WriteLine($"Enter the student Acadamic year");
                        int acadamicYear = Convert.ToInt32(Console.ReadLine());
                        studentInfoObject = new StudentInfo(name, fatherName, phone, email, dob, gender, standard, branch, acadamicYear);
                        Console.WriteLine($"Student info object created  and the id is {studentInfoObject.RegisterNumber}");

                        break;
                    }
                case 3:
                    {
                        //display the details if the student object exists
                        if (studentInfoObject != null)
                        {
                            Console.WriteLine(studentInfoObject.DisplayStudentInfo());
                        }
                        else
                        {
                            Console.WriteLine($"Please Enter Personal info first");
                        }

                        break;
                    }
                case 4:
                    {
                        //breakin the loop 
                        isLoopContinue = false;
                        break;
                    }
                default:
                    {
                        //handling the wrong inputs
                        Console.WriteLine($"Invalid Input");
                        break;
                    }
            }

        } while (isLoopContinue);

    }
}