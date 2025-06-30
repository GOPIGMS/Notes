using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementApplication.Enums;

namespace HotelManagementApplication.Models
{
    /// <summary>
    /// Room Selection Class <see cref="RoomSelectionDetails"/>
    /// </summary>
    public class RoomSelectionDetails
    {
        //fiels of RoomSelectionDetails
        private static int s_selectionID = 1000;
        //properties
        public string SelectionID { get; set; }
        public string BookingID { get; set; }
        public string RoomID { get; set; }
        public DateTime StayingDateFrom { get; set; }
        public DateTime StayingDateTo { get; set; }
        public double Price { get; set; }
        public double NumberOfDays { get; set; }
        public BookingStatusDetails BookingStatus { get; set; }
        //constructors of RoomSelectionDetails
        public RoomSelectionDetails() { }
        //parameterized constructors of RoomSelectionDetails
        public RoomSelectionDetails(string selectionID, string bookingID, string roomID, DateTime stayingDateFrom, DateTime stayingDateTo, double price, double numberOfDays, BookingStatusDetails bookingStatus)
        {
            SelectionID = selectionID;
            BookingID = bookingID;
            RoomID = roomID;
            StayingDateFrom = stayingDateFrom;
            StayingDateTo = stayingDateTo;
            Price = price;
            NumberOfDays = numberOfDays;
            BookingStatus = bookingStatus;
            ++s_selectionID;
        }
        //for dynamic constructor creation
        public RoomSelectionDetails(string details)
        {
            string[] values =details.Split(',');
            SelectionID = values[0];
            BookingID = values[1];
            RoomID = values[2];
            StayingDateFrom = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            StayingDateTo = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            Price = Convert.ToDouble(values[5]);
            NumberOfDays = Convert.ToDouble(values[5]);
            BookingStatus = Enum.Parse<BookingStatusDetails>(values[6],true);
            ++s_selectionID;
        }
        public RoomSelectionDetails(string bookingID, string roomID, DateTime stayingDateFrom, DateTime stayingDateTo, double price, double numberOfDays, BookingStatusDetails bookingStatus)
        {
            SelectionID = $"SID{++s_selectionID}";
            BookingID = bookingID;
            RoomID = roomID;
            StayingDateFrom = stayingDateFrom;
            StayingDateTo = stayingDateTo;
            Price = price;
            NumberOfDays = numberOfDays;
            BookingStatus = bookingStatus;

        }
    }

}