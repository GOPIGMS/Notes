using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class LinearSearchOnString
    {
        static string[] array = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        public static void SearchElementCreation()
        {
            Console.WriteLine($"Enter the element that you want to search");
            string searchElement = Console.ReadLine();
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
        public static int LinearSearch(string[] array, string searchElement)
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