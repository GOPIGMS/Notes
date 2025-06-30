using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearchOnString
    {
        static string[] array = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        public static void SearchElementCreation()
        {
            Array.Sort(array);
            Console.WriteLine($"Enter the element that you want to search");
            string searchElement = Console.ReadLine();
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
        public static int BinarySearch(string[] array, string searchElement)
        {
            int low =0;
            int high =array.Length-1;
            while(low<=high){
                int mid = (low+high)/2;
                if(array[mid].CompareTo(searchElement)==0){
                    return mid;
                }
                else if(array[mid].CompareTo(searchElement)==1){
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