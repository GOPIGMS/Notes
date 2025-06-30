using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSortOnDouble
    {
        public static void SortArray()
        {
            double[] array = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxindex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[maxindex] < array[j])
                    {
                        maxindex = j;

                    }

                }
                double temp = array[maxindex];
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