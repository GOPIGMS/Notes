using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformation
{
    public abstract class Car
    {
        //fields
        private static int s_noOfWheels = 4;
        public static int s_noOfDoors = 4;
        //properties
        public EngineTypeDetails EngineType { get; set; }
        public int NoOfSeats { get; set; }
        public double Price { get; set; }
        public CarTypeDetails CarType { get; set; }

        //methods
        //showing wheels
        public int ShowWheels()
        {
            return s_noOfWheels;
        }
        //showing doors
        public int ShowDoors()
        {
            return s_noOfDoors;
        }
        //abstract method
        public abstract EngineTypeDetails GetEngineType();
        public abstract int GetNoOfSeats();
        public abstract double GetPrice();
        public abstract CarTypeDetails GetCarType();
        public abstract string DisplayCarDetails();




    }
}