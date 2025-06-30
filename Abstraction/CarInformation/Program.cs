using System;
using System.Runtime.InteropServices;

namespace CarInformation;

class Program
{
    public static void Main(string[] args)
    {
        //getting and intializing the value for the property MaruthiSwift
        Console.WriteLine($"Enter the Engine Type");
        EngineTypeDetails engineType = Enum.Parse<EngineTypeDetails>(Console.ReadLine(), true);
        Console.WriteLine($"Enter the no of seats ");
        int noOfSeats = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the Price");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Enter the Car Type");
        CarTypeDetails carType = Enum.Parse<CarTypeDetails>(Console.ReadLine(), true);
        MaruthiSwift maruthiSwiftObject = new MaruthiSwift(engineType, noOfSeats, price, carType);
        Console.WriteLine($"The car details are: {maruthiSwiftObject.DisplayCarDetails()}");
        //creating the object for SuzukiCiaz
        Console.WriteLine($"Enter the Engine Type");
        EngineTypeDetails engineType2 = Enum.Parse<EngineTypeDetails>(Console.ReadLine(), true);
        Console.WriteLine($"Enter the no of seats ");
        int noOfSeats2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the Price");
        double price2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Enter the Car Type");
        CarTypeDetails carType2 = Enum.Parse<CarTypeDetails>(Console.ReadLine(), true);
        SuzukiCiaz suzukiCiazObject = new SuzukiCiaz(engineType2, noOfSeats2, price2, carType2);
        Console.WriteLine($"The car details are: {suzukiCiazObject.DisplayCarDetails()}");

    }
}