using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace CarModels;

class Program
{
    public static void Main(string[] args)
    {
        //Performing operation twice
        for (int i = 0; i < 2; i++)
        {
            //properties initialization
            Console.WriteLine($"Getting the Details of ShiftDezire car{i + 1}");
            Console.WriteLine($"Enter the Engine Number");
            string engineNumber = Console.ReadLine();
            Console.WriteLine($"Enter the Chasis Number");
            string chasisNumber = Console.ReadLine();
            Console.WriteLine($"Enter the Brand Name");
            string brandName = Console.ReadLine();
            Console.WriteLine($"Enter the model name");
            string modelName = Console.ReadLine();
            Console.WriteLine($"Enter the fuel Type");
            string fuelType = Console.ReadLine();
            Console.WriteLine($"Enter the Number of Seats");
            int numberOfSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Color");
            string color = Console.ReadLine();
            Console.WriteLine($"Enter the Tank Capacity");
            int tankCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the no of kilo meters driven");
            double numberOfKmDriven = Convert.ToDouble(Console.ReadLine());
            //creating object
            ShiftDezire shiftDezireObject1 = new ShiftDezire(engineNumber, chasisNumber, brandName, modelName, fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven);
            //displaying details
            Console.WriteLine($"The details are : {shiftDezireObject1.ShowDetails()}");
            //calculating milage
            Console.WriteLine($"The mileage  is : {shiftDezireObject1.CalulateMilage()}");
        }
        //Performing operation twice for eco car
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Getting the Details of ECO car{i + 1}");
            //properties initialization
            Console.WriteLine($"Enter the Engine Number");
            string engineNumber = Console.ReadLine();
            Console.WriteLine($"Enter the Chasis Number");
            string chasisNumber = Console.ReadLine();
            Console.WriteLine($"Enter the Brand Name");
            string brandName = Console.ReadLine();
            Console.WriteLine($"Enter the model name");
            string modelName = Console.ReadLine();
            Console.WriteLine($"Enter the fuel Type");
            string fuelType = Console.ReadLine();
            Console.WriteLine($"Enter the Number of Seats");
            int numberOfSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Color");
            string color = Console.ReadLine();
            Console.WriteLine($"Enter the Tank Capacity");
            int tankCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the no of kilo meters driven");
            double numberOfKmDriven = Convert.ToDouble(Console.ReadLine());
            //object creation
            Eco ecoObject = new Eco(engineNumber, chasisNumber, brandName, modelName, fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven);
            //displaying details
            Console.WriteLine($"The details are : {ecoObject.ShowDetails()}");
            Console.WriteLine($"The mileage  is : {ecoObject.CalulateMilage()}");
        }
    }
}