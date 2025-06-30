using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortOnString
    {
        public static void SortArray()
        {
             string[] array = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1].CompareTo(array[j])==1)
                    {
                        string temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}