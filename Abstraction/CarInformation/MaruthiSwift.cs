using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformation
{
    public class MaruthiSwift : Car
    {
        //creating constructor
        public MaruthiSwift() { }
        public MaruthiSwift(EngineTypeDetails engineType, int noOfSeats, double price, CarTypeDetails carType)
        {
            EngineType = engineType;
            NoOfSeats = noOfSeats;
            Price = price;
            CarType = carType;
        }
        //overriding the methods
        public override EngineTypeDetails GetEngineType()
        {
            return EngineType;

        }
        //getting no of seats
        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override double GetPrice()
        {
            return Price;
        }
        public override CarTypeDetails GetCarType()
        {
            return CarType;
        }
        //displaying car Details
        public override string DisplayCarDetails()
        {
            return $"No Of Wheels : {ShowWheels()} No of Doors : {ShowDoors()}, Engine Type : {GetEngineType()},No of seats :{GetNoOfSeats()},Price :{GetPrice()},Car Type :{GetCarType()}";
        }
    }
}