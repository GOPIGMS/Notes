using System;

namespace MultilevelOnlineLibrary;

class Program
{
    public static void Main(string[] args)
    {
        //creating the global book object 
        BookInfo bookInfoObject = null;
        bool isLoopContinue = true;
        //displaying the menu and getting the input
        do
        {
            Console.WriteLine($"Enter the option to perform operation \n1.Create Book Info\n2.DisplayDetails\n3.Exit");
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
                //getting the input values and creating the object
                case 1:
                    {
                        Console.WriteLine($"Enter the Department name");
                        string departmentName = Console.ReadLine();
                        Console.WriteLine($"Enter the Degree");
                        string degree = Console.ReadLine();
                        Console.WriteLine($"Enter the Racknumber");
                        int rackNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Column number");
                        int columnNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the Book Name");
                        string bookName = Console.ReadLine();
                        Console.WriteLine($"Enter the Author Name");
                        string authorName = Console.ReadLine();
                        Console.WriteLine($"Enter the price");
                        double price = Convert.ToDouble(Console.ReadLine());
                        bookInfoObject = new BookInfo(bookName, authorName, price, rackNumber, columnNumber, departmentName, degree);
                        Console.WriteLine($"Book object created");
                        break;

                    }
                case 2:
                    {
                        //displaying details
                        if (bookInfoObject != null)
                        {
                            Console.WriteLine(bookInfoObject.DisplayInfo());
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
                        //accepting invalid input and showing invalid
                        Console.WriteLine($"Invalid Input");
                        break;
                    }
            }
        } while (isLoopContinue);
    }
}