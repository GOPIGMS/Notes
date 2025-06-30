using System;

namespace BubbleSort;

class Program
{
    public static void Main(string[] args)
    {
        string whileContinue = "";
        do
        {
            int option;
            Console.WriteLine("Select the option to perform the Bubble sort  in Descending Order on the various datatypes\n1.Integer\n2.String\n3.Character\n4.Double");
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine($"Please Enter the valid Input");
            }
            switch (option)
            {
                case 1:
                    {
                        BubbleSortOnIntegers.SortArray();
                        break;
                    }
                case 2:
                    {
                        BubbleSortOnString.SortArray();
                        break;
                    }
                case 3:
                    {
                        BubbleSortOnCharacters.SortArray();
                        break;
                    }
                case 4:
                    {
                        BubbleSortOnDouble.SortArray();
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