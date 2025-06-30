using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InserttionSortOnIntegers
    {
        public static void SortArray()
        {
            int[] array = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j -1];
                        array[j -1] = temp;

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