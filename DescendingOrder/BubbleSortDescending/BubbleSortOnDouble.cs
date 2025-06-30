using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSortOnDouble
    {
        public static void SortArray()
        {
            double[] array = { 1.1,65.3,93.9,55.5,3.5,6.9};
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
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