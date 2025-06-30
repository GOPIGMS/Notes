using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public class ShiftDezire : Car, IBrand
    {
        //creating properties
        private static int s_makingID = 0;
        public int MakingID { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        //default constructor
        public ShiftDezire() { }
        //parametrized constructor
        public ShiftDezire(string engineNumber, string chasisNumber, string brandName, string modelName, string fuelType, int numberOfSeats, string color, int tankCapacity, double numberOfKmDriven) : base(fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            MakingID = s_makingID;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName = modelName;
        }
        //show  Shift Dezire details
        public string ShowDetails()
        {
            return $"\nMakingID : {MakingID}, EngineNumber : {EngineNumber}, ChasisNumber : {ChasisNumber}, Brand Name :{BrandName}, Model Name :{ModelName},\nFuel Type : {FuelType}, Number Of Seats :{NumberOfSeats},Color : {Color}, Tank Capacity : {TankCapacity}, Number Of Kilometers Driven : {NumberOfKmDriven}";
        }
    }
}