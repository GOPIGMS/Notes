using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementApplication.Enums;

namespace HotelManagementApplication.Models
{
    /// <summary>
    /// Booking Class Details <see cref="BookingDetails"/>
    /// </summary> 
    public class BookingDetails
    {
        //field of BookingDetails 
        private static int s_bookingID = 100;
        //properties
        public string BookingID { get; set; }
        public string UserID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatusDetails BookingStatus { get; set; }
        //constructors
        public BookingDetails() { }
        //paramerized constructors
        public BookingDetails(string bookingID, string userID, double totalPrice, DateTime dateOfBooking, BookingStatusDetails bookingStatus)
        {
            BookingID = bookingID;
            UserID = userID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
            ++s_bookingID;
        }
        public BookingDetails(string details)
        {
            string [] values =details.Split(',');
            BookingID = values[0];
            UserID = values[1];
            TotalPrice = Convert.ToDouble(values[2]);
            DateOfBooking = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus = Enum.Parse<BookingStatusDetails>(values[4],true);
            ++s_bookingID;
        }
        public BookingDetails(string userID, double totalPrice, DateTime dateOfBooking, BookingStatusDetails bookingStatus)
        {
            BookingID = $"BID{++s_bookingID}";
            UserID = userID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
            ++s_bookingID;
        }
    }
}