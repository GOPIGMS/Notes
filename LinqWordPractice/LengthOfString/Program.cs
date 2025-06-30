using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace LengthOfString;

class Program
{
    public static void Main(string[] args)
    {
        //creating the string array of values
        List<string> values = new List<string>() { "ABU DHABI", "AMSTERDAM", "ROME", "PARIS", "CALIFORNIA","LONDON", "NEW DELHI", "ZURICH", "NAIROBI", };
        //creating the query
        var query = (from str in values
                    orderby  str.Length , str 
                    select str).ToList();
        foreach (var value in query)
        {

            Console.WriteLine($"{value}");

        }

    }
}