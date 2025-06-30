using System;

namespace MyDictonary;

class Program{
    public static void Main(string[] args)
    {
        //creating the instance for the custom dictonary class
        MyDictonary<string,string> dictonary=new MyDictonary<string, string>();
        //adding the elements in the custom dictonary class
        dictonary.Add("Gopi","Govindaraj");
        dictonary.Add("Gokul","Govindaraj");
        dictonary.Add("Saravanan","Govindaraj");
        dictonary.Add("Saravanan","Govindaraj N");
        //creating the custom for each loop and iterating all the values
        foreach(KeyValue<string,string> data in dictonary){
            Console.WriteLine($"Key  {data.Key} Value {data.Value}");   
        }
        //creating the indexer for the dictonary and getting the values through the key
        string fatherName =dictonary["Gopi"];
        Console.WriteLine($"Father Name is {fatherName}");
        //setting the indexer for the dictonary and setting the values through the key
        dictonary["Gopi"]="Govindaraj N";
        string fatherNameUpdated =dictonary["Gopi"];
        Console.WriteLine($"Father Name is {fatherNameUpdated}");
    }
}