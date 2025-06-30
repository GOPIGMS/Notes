using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineTheatreTicketBooking.Enums;

namespace OnlineTheatreTicketBooking.Models
{
    /// <summary>
    /// BookingDetails class used to store the booking details <see cref="BookingDetails"/>
    /// </summary>
    public class BookingDetails
    {
        //fields
        /// <summary>
        /// field used to auto increment the booking id <see cref="BookingDetails"/>
        /// </summary>
        private static int s_bookingID =7000;
        //properties
        /// <summary>
        /// Property used to auto store the booking id <see cref="BookingDetails"/>
        /// </summary>
        public string BookingID {get;set;}
        /// <summary>
        /// Property used to auto store the user id <see cref="BookingDetails"/>
        /// </summary>
        public string UserID {get;set;}
        /// <summary>
        /// Property used to auto store the movie id <see cref="BookingDetails"/>
        /// </summary>
        public string MovieID {get;set;}
        /// <summary>
        /// Property used to auto store the Theater id <see cref="BookingDetails"/>
        /// </summary>
        public string TheatreID {get;set;}
        /// <summary>
        /// Property used to store the seat count
        /// </summary>
        public int SeatCount {get;set;}
        /// <summary>
        /// property used to store the total amount <see cref="BookingDetails"/>
        /// </summary>
        /// <value></value>
        public double TotalAmount {get;set;}
        /// <summary>
        /// property used to store the Booking <see cref="BookingDetails"/>
        /// </summary>
        public BookingStatusDetails BookingStatus {get;set;}
        //constructors
        /// <summary>
        /// Default Constructor of <see cref="BookingDetails"/>
        /// </summary>
        public BookingDetails(){}
        //parameterized Constructors 
        /// <summary>
        ///  Parameterized Constructor of <see cref="BookingDetails"/>
        /// </summary>
        /// <param name="bookingID">bookingID parameter is a string used to set the booking id property</param>
        /// <param name="userID">bookingID parameter is a string used to set the booking id property</param>
        /// <param name="movieID">movieID parameter is a string used to set the mail id property </param>
        /// <param name="theatreID">theatreID parameter is a string used to set the theatre id property </param>
        /// <param name="seatCount">seatCount parameter is a int used to set the seatCount property  </param>
        /// <param name="totalAmount">totalamount parameter is a double used to set the total amount property </param>
        /// <param name="bookingStatus">booking status parameter is a enum used to set the BookingStatus property</param>
        public BookingDetails(string bookingID, string userID, string movieID, string theatreID, int seatCount, double totalAmount, BookingStatusDetails bookingStatus)
        {
            BookingID = bookingID;
            UserID = userID;
            MovieID = movieID;
            TheatreID = theatreID;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;
            ++s_bookingID;
        }
        //parameterized Constructors 
        /// <summary>
        ///  Parameterized Constructor of <see cref="BookingDetails"/>
        /// <param name="details">string of values used to initialize the value</param>
        public BookingDetails(string details)
        {
            string[] values =details.Split(',');
            BookingID = values[0];
            UserID = values[1];
            MovieID = values[2];
            TheatreID = values[3];
            SeatCount = Convert.ToInt32(values[4]);
            TotalAmount = Convert.ToDouble(values[5]);
            BookingStatus =Enum.Parse<BookingStatusDetails>(values[6],true);
            ++s_bookingID;
        }
                //parameterized Constructors 
        /// <summary>
        ///  Parameterized Constructor of <see cref="BookingDetails"/>
        /// </summary>
        /// <param name="userID">bookingID parameter is a string used to set the booking id property</param>
        /// <param name="movieID">movieID parameter is a string used to set the mail id property </param>
        /// <param name="theatreID">theatreID parameter is a string used to set the theatre id property </param>
        /// <param name="seatCount">seatCount parameter is a int used to set the seatCount property  </param>
        /// <param name="totalAmount">totalamount parameter is a double used to set the total amount property </param>
        /// <param name="bookingStatus">booking status parameter is a enum used to set the BookingStatus property</param>
        public BookingDetails( string userID, string movieID, string theatreID, int seatCount, double totalAmount, BookingStatusDetails bookingStatus)
        {
            BookingID =$"BID{++s_bookingID}";
            UserID = userID;
            MovieID = movieID;
            TheatreID = theatreID;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus; 
        }

    }
    

}