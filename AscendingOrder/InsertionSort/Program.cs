using System;
using InsertionSort;

namespace InsertionSort;

class Program
{
    public static void Main(string[] args)
    {
        string whileContinue = "";
        do
        {
            int option;
            Console.WriteLine("Select the option to perform the Insertion sort on the various datatypes\n1.Integer\n2.String\n3.Character\n4.Double");
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine($"Please Enter the valid Input");
            }
            switch (option)
            {
                case 1:
                    {
                        InsertionSortOnIntegers.SortArray();
                        break;
                    }
                case 2:
                    {
                        InsertionSortOnString.SortArray(); 
                        break;
                    }
                case 3:
                    {
                        InsertionSortOnCharacter.SortArray();
                        break;
                    }
                case 4:
                    {
                        InsertionSortOnDouble.SortArray();
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Invalid Input");

                        break;
                    }
            }
            Console.WriteLine($"Enter yes if you want to continue");

            whileContinue = Console.ReadLine().ToLower();

        } while (whileContinue == "yes");
    }
}