using System;
namespace StudentsDetailInfo;

class Program
{
    public static void Main(string[] args)
    {
        //creating the hscdetail class object for global access
        HSCDetails hscInfoObject = null;
        bool isLoopContinue = true;
        //displaying the menu and getting the input from the user
        do
        {
            Console.WriteLine($"Enter the option to perform operation \n1.Create DSC Marksheet\n2.Get Mark \n3.Calculate Total and percentage\n4.DisplayDetails\n5.Exit");
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
                //getting values from the user and creating the object
                case 1:
                    {
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
                        Console.WriteLine($"Enter Student RegisterNumber");
                        int studentRegisterNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Student Standard");
                        string standard = Console.ReadLine();
                        Console.WriteLine($"Enter the branch");
                        string branch = Console.ReadLine();
                        Console.WriteLine($"Enter the student Acadamic year");
                        int acadamicYear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Physics Mark");
                        int physics = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Chemistry Mark");
                        int chemistry = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Maths Mark");
                        int maths = Convert.ToInt32(Console.ReadLine());
                        hscInfoObject = new HSCDetails(physics, chemistry, maths, studentRegisterNumber, name, fatherName, phone, email, dob, gender, standard, branch, acadamicYear);
                        break;
                    }
                case 2:
                    {
                        //displaying marks
                        if (hscInfoObject != null)
                        {
                            Console.WriteLine(hscInfoObject.GetMarks());
                        }
                        else
                        {
                            Console.WriteLine($"Please Enter Personal info first");
                        }

                        break;
                    }
                case 3:
                    {
                        //calculating total and percentage
                        if (hscInfoObject != null)
                        {
                            Console.WriteLine($"The total Mark is {hscInfoObject.TotalCalculation()} .The Percentage is {hscInfoObject.PercentageCalculation()}");
                        }
                        else
                        {
                            Console.WriteLine($"Please Enter Personal info first");
                        }

                        break;
                    }
                case 4:
                    {
                        //showing the marksheet
                        if (hscInfoObject != null)
                        {
                            Console.WriteLine($"The user mark sheet details is given below {hscInfoObject.ShowMarkSheet()}");
                        }
                        else
                        {
                            Console.WriteLine($"Please Enter Personal info first");
                        }

                        break;
                    }
                case 5:
                    {
                        //terminating the loop
                        isLoopContinue = false;
                        break;
                    }
                default:
                    {
                        //handling the invalid data
                        Console.WriteLine($"Invalid Input");
                        break;
                    }
            }

        } while (isLoopContinue);
    }
}