using System;
using System.Net.WebSockets;

namespace ShopDiscount;

class Program
{
    public static void Main(string[] args)
    {
        //getting the values for the Ladies wear
        Console.WriteLine($"Enter the Dress Type");
        DressTypeDetails dressType = Enum.Parse<DressTypeDetails>(Console.ReadLine(), true);
        Console.WriteLine($"Enter the dress Name");
        string dressName = Console.ReadLine();
        Console.WriteLine($"Enter The price");
        Double price = Convert.ToDouble(Console.ReadLine());
        //creating the object for ladies Wear
        LadiesWear ladiesWearObject = new LadiesWear(dressType, dressName, price);
        Console.WriteLine($"The dress info is :\n {ladiesWearObject.GetDressInfo()}");
        Console.WriteLine($"The Bill :\n {ladiesWearObject.DisplayInfo()}");
        //getting the values for the Mens wear
        Console.WriteLine($"Enter the Dress Type");
        DressTypeDetails dressType1 = Enum.Parse<DressTypeDetails>(Console.ReadLine(), true);
        Console.WriteLine($"Enter the dress Name");
        string dressName1 = Console.ReadLine();
        Console.WriteLine($"Enter The price");
        Double price1 = Convert.ToDouble(Console.ReadLine());
        //creating the object for Mens Wear
        MensWear mensWearObject = new MensWear(dressType1, dressName1, price1);
        Console.WriteLine($"The dress info is :\n {mensWearObject.GetDressInfo()}");
        Console.WriteLine($"The Bill :\n {mensWearObject.DisplayInfo()}");

    }
}
