using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public class Car
    {
        //creating base car class properties
        public string FuelType { get; set; }
        public string Color { get; set; }
        public int NumberOfSeats { get; set; }
        public int TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        //creating default constructor
        public Car() { }
        //creating prameterized constructor
        public Car(string fuelType, int numberOfSeats, string color, int tankCapacity, double numberOfKmDriven)
        {
            FuelType = fuelType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
        //calculating milage
        public double CalulateMilage()
        {
            Console.WriteLine($"Enter the Total fuel Consumed :");
            double fuelConsumed = Convert.ToDouble(Console.ReadLine());
            return NumberOfKmDriven / fuelConsumed;
        }


    }
}