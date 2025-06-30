using System;

namespace LinearSearch;

class Program
{
    public static void Main(string[] args)
    {
        //creating menu to perform linear search operation on the specific data Type
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
                    LinearSearchOnInteger.SearchElementCreation();
                    break;
                }
            case 2:
                {
                    LinearSearchOnString.SearchElementCreation();

                    break;
                }
            case 3:
                {
                    LinearSearchOnCharacter.SearchElementCreation();

                    break;
                }
            case 4:
                {
                    LinearSearchOnDecimal.SearchElementCreation();
                    break;
                }
            default:
                {
                    Console.WriteLine($"Please Enter the valid input data");
                    break;
                }
        }



    }
}