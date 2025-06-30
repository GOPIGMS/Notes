using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementApplication.Enums;

namespace HotelManagementApplication.Models
{
    /// <summary>
    /// Room Details Class <see cref="RoomDetails"/>
    /// </summary>
    public class RoomDetails
    {
        //fields of RoomDetails
        private static int s_roomID = 100;
        //properties
        public string RoomID { get; set; }
        public RoomTypeDetails RoomType { get; set; }
        public int NumberOfBeds { get; set; }
        public double PricePerDay { get; set; }
        //constructors of RoomDetails
        public RoomDetails() { }
        //parameterized constructors
        public RoomDetails(string roomID, RoomTypeDetails roomType, int numberOfBeds, double pricePerDay)
        {
            RoomID = roomID;
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
            PricePerDay = pricePerDay;
            ++s_roomID;
        }
        //for dynamic value creation
        public RoomDetails(string details)
        {
            string[] values =details.Split(',');
            RoomID = values[0];
            RoomType = Enum.Parse<RoomTypeDetails>(values[1],true);
            NumberOfBeds = Convert.ToInt32(values[2]);
            PricePerDay = Convert.ToDouble(values[3]);
            ++s_roomID;
        }
        public RoomDetails(RoomTypeDetails roomType, int numberOfBeds, double pricePerDay)
        {
            RoomID = $"RID{++s_roomID}";
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
            PricePerDay = pricePerDay;
        }
    }
}