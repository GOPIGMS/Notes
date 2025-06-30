using System;

namespace BinarySearch;

class Progrma
{
    public static void Main(string[] args)
    {
        string whileContinue = "";
        do
        {
            //creating menu to perform Binary search operation on the specific data Type
        Console.WriteLine($"Select the option to perform the Linear Search on the Data Type \n1.Integer\n2.String\n3.Character\n4.Double ");
        int option;
        //handling the input error here
        while (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine($"Please Enter the valid input");
        }
        switch (option)
        {
            case 1:
                {
                    BinarySearchOnIntegers.SearchElementCreation();
                    break;
                }
            case 2:
                {
                    BinarySearchOnString.SearchElementCreation();
                    break;
                }
            case 3:
                {
                    BinarySearchOnCharacter.SearchElementCreation();

                    break;
                }
            case 4:
                {
                    BinarySearchOndouble.SearchElementCreation();
                    break;
                }
            default:
                {
                    Console.WriteLine($"Please Enter the valid input data");
                    break;
                }
        }

        Console.WriteLine($"Enter yes to continue");
        whileContinue =Console.ReadLine().ToLower();   
        } while( whileContinue.Equals("yes"));
    }
}
