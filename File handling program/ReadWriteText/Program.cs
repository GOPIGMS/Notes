using System;
using System.IO;

namespace ReadWriteText;

class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestData"))
        {
            Console.WriteLine($"Creating the Test Data folder");
            Directory.CreateDirectory("TestData");
        }
        else
        {
            Console.WriteLine($"The directory already presents");

        }
        if (!File.Exists("TestData/TextFile.txt"))
        {
            Console.WriteLine($"Creating a new Text File");
            File.Create("TestData/TextFile.txt").Close();
        }
        else
        {
            Console.WriteLine($"The text file already exists");

        }
        System.Console.WriteLine("Enter 1. To Display the data \n2.To Write data in the file");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    Console.WriteLine($"Display the data in the file");
                    StreamReader sr = new StreamReader("TestData/TextFile.txt");
                    string data =sr.ReadLine();
                    while(data != null){
                        Console.WriteLine($"{data}");
                        data=sr.ReadLine();
                        
                    }
                    sr.Close();
                    break;
                }
            case 2:
                {
                    Console.WriteLine($"Writing the data in the file");
                    string[] content =File.ReadAllLines("TestData/TextFile.txt");
                    StreamWriter sw = new StreamWriter("TestData/TextFile.txt");
                    Console.WriteLine($"Enter the data you want to read");
                    string data = Console.ReadLine();
                    string old ="";
                   foreach(string line in content ){
                    old=old+line+'\n';
                   } 
                   old=old+data+'\n';
                   sw.WriteLine(old);
                   sw.Close();     
                    break;
                }



        }
    }
}