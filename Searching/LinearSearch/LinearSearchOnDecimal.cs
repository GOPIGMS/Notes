using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class LinearSearchOnDecimal
    {

        static double[] array = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        public static void SearchElementCreation()
        {
            Console.WriteLine($"Enter the element that you want to search");
            double searchElement;
            while (!double.TryParse(Console.ReadLine(), out searchElement))
            {
                Console.WriteLine($"Please Enter the valid Element to search");
            }
            int index = LinearSearch(array, searchElement);
            if (index == -1)
            {
                Console.WriteLine($"The element {searchElement} is not found in the array");
            }
            else
            {
                Console.WriteLine($"The element {searchElement} is present in the array.And its positon is {index}");
            }


        }
        public static int LinearSearch(double[] array, double searchElement)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchElement)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}