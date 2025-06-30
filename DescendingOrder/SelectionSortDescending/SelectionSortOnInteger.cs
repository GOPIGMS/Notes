using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSortOnInteger
    {

        public static void SortArray()
        {
            int[] array = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
            for (int i = 0; i < array.Length-1; i++)
            {
                int maxindex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[maxindex] < array[j])
                    {
                        maxindex = j;

                    }

                }
                int temp = array[maxindex];
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