using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public static class  LinearSearchOnCharacter
    {
        static char[] array={'c','a','f','b','k','h','j','l','i','z','t','m','p','l','d'};
        public static void SearchElementCreation(){
            Console.WriteLine($"Enter the element that you want to search");
            char searchElement ;
            while(! char.TryParse(Console.ReadLine(),out searchElement)){
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
        public static int LinearSearch(char[] array,char searchElement){
            for (int i=0;i<array.Length;i++){
                if(array[i]==searchElement){
                    return i;
                }
            }
            return -1;
        }
        
        
    }
}