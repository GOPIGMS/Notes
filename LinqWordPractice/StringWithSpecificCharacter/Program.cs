using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace StringWithSpecificCharacter;

class Program
{
    public static void Main(string[] args)
    {
         List<int> values =new List<int>() {1,2,3,4,5,6,7,8} ;
         var query = from obj in values
                      where obj >2 
                      select obj;
        foreach (var value in query){
            Console.WriteLine($"{value}");
            
        }

    }
}