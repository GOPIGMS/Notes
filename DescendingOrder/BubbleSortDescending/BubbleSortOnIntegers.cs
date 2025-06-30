using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleSort
{

    public static class BubbleSortOnIntegers
    {

        //sorting
        public static void SortArray()
        {
            int[] array = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
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