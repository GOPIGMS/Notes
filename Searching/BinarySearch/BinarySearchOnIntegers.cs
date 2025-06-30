using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearchOnIntegers
    {

        static int[] array = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };

        public static void SearchElementCreation()
        {
            Array.Sort(array);
            Console.WriteLine($"Enter the element that you want to search");
            int searchElement;
            while (!int.TryParse(Console.ReadLine(), out searchElement))
            {
                Console.WriteLine($"Please Enter the valid Element to search");
            }
            int index = BinarySearch(array, searchElement);
            if (index == -1)
            {
                Console.WriteLine($"The element {searchElement} is not found in the array");
            }
            else
            {
                Console.WriteLine($"The element {searchElement} is present in the array.And its positon is {index}");
            }
        }
        public static int BinarySearch(int[] array, int searchElement)
        {
            int low =0;
            int high =array.Length-1;
            while(low<=high){
                int mid = (low+high)/2;
                if(array[mid]==searchElement){
                    return mid;
                }
                else if(array[mid]>searchElement){
                    high=mid-1;
                }
                else{
                    low=mid+1;
                }
            }
            return -1;
        }
    }
}