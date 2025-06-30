using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSortOnString
    {

        public static void SortArray()
        {
            string[] array = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

            for (int i = 0; i < array.Length-1; i++)
            {
                int maxindex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[maxindex].CompareTo(array[j])==-1 )
                    {
                        maxindex = j;

                    }

                }
                string temp = array[maxindex];
                array[maxindex] = array[i];
                array[i] = temp;
            }
            Console.WriteLine($"The sorted array is ");
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

        }
    }
}