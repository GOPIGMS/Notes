using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortOnDouble
    {
        public static void SortArray()
        {
            double[] array = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] < array[j])
                    {
                        double temp = array[j];
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