using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortOnCharacter
    {
        public static void SortArray()
        {
            char[] array = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        char temp = array[j];
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