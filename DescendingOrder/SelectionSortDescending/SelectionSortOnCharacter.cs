using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSortOnCharacter
    {
        public static void SortArray()
        {
            char[] array = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
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
                char temp = array[maxindex];
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