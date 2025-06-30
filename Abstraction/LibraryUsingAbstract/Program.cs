using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Tracing;

namespace LibraryUsingAbstract;

class Program
{
    public static void Main(string[] args)
    {
        //creating the golbal objects and wrapping it with try catch
        try
        {
            bool isLoopContinue = true;
            CSELibraryInfo cseBookObject = null;
            EEELibraryInfo eeeBookObject = null;
            do
            {
                //displaying the menu and getting the data
                Console.WriteLine($"Enter the option to perform operation \n1.Set book for CSE \n2.Set book for EEE \n3.Display book info\n4.Exit");
                int option;
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    option = 0;
                }
                //creating the switch case option
                switch (option)
                {
                    case 1:
                        {
                            //getting the input from the user and creating the object
                            cseBookObject = new CSELibraryInfo();
                            Console.WriteLine($"Enter the Author Name");
                            string authorName = Console.ReadLine();
                            Console.WriteLine($"Enter the Book Name");
                            string bookName = Console.ReadLine();
                            Console.WriteLine($"Enter the Publisher Name");
                            string publisherName = Console.ReadLine();
                            Console.WriteLine($"Enter the year");
                            int year = Convert.ToInt32(Console.ReadLine());
                            cseBookObject.SetBookInfo(authorName, bookName, publisherName, year);
                            Console.WriteLine($"CSE book object can be created");
                            break;
                        }
                    case 2:
                        {
                            //getting the input from the user and creating the object
                            eeeBookObject = new EEELibraryInfo();
                            Console.WriteLine($"Enter the Author Name");
                            string authorName = Console.ReadLine();
                            Console.WriteLine($"Enter the Book Name");
                            string bookName = Console.ReadLine();
                            Console.WriteLine($"Enter the Publisher Name");
                            string publisherName = Console.ReadLine();
                            Console.WriteLine($"Enter the year");
                            int year = Convert.ToInt32(Console.ReadLine());
                            eeeBookObject.SetBookInfo(authorName, bookName, publisherName, year);
                            cseBookObject = null;
                            Console.WriteLine($"EEE Book object can created");
                            break;
                        }

                    case 3:
                        {
                            //display the details
                            if (cseBookObject != null)
                            {
                                cseBookObject.DisplayInfo();
                            }
                            else if (eeeBookObject != null)
                            {
                                eeeBookObject.DisplayInfo();
                            }
                            else
                            {
                                Console.WriteLine($"Please create a object first");

                            }
                            break;
                        }

                    case 4:
                        {
                            //terminating the loop
                            isLoopContinue = false;
                            break;
                        }
                    default:
                        {
                            //getting the invalid value
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
