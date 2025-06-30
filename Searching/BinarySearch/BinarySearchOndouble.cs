using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinarySearchOndouble
    {
        
        static double[] array = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        public static void SearchElementCreation()
        {
            Array.Sort(array);
            Console.WriteLine($"Enter the element that you want to search");
            double searchElement;
            while (!double.TryParse(Console.ReadLine(), out searchElement))
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
        public static int BinarySearch(double[] array, double searchElement)
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