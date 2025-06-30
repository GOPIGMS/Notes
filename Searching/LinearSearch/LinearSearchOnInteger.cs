using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class LinearSearchOnInteger
    {
        static int[] array={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        public static void SearchElementCreation(){
            Console.WriteLine($"Enter the element that you want to search");
            int searchElement ;
            while(! int.TryParse(Console.ReadLine(),out searchElement)){
                Console.WriteLine($"Please Enter the valid Element to search");     
            }
            int index =LinearSearch(array,searchElement);
            if(index ==-1){
                Console.WriteLine($"The element {searchElement} is not found in the array");            
            }
            else{
                Console.WriteLine($"The element {searchElement} is present in the array.And its positon is {index}");
            }  
        }
        public static int LinearSearch(int[] array,int searchElement){
            for (int i=0;i<array.Length;i++){
                if(array[i]==searchElement){
                    return i;
                }
            }
            return -1;
        }
        
  
        
    }
}