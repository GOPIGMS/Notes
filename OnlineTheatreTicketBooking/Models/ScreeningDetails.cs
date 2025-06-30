using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking.Models
{
    /// <summary>
    /// ScreeningDetails class stores the data of the screen <see cref="ScreeningDetails"/>
    /// </summary>
    public class ScreeningDetails
    {
        //field
        /// <summary>
        /// s_screenigID field used to auto increment the movie id <see cref="ScreeningDetails"/>
        /// </summary>
        private static int s_screenigID =100;
        // properties
        /// <summary>
        /// Property used to store ScreeningID <see cref="ScreeningDetails"/>
        /// </summary>
        public string ScreeningID {get;set;}
        /// <summary>
        /// Property used to store MovieID <see cref="ScreeningDetails"/>
        /// </summary>
        /// <value></value>
        public string MovieID {get;set;}
        /// <summary>
        /// Property used to store TheatreID <see cref="ScreeningDetails"/>
        /// </summary>
        /// <value></value>
        public string TheatreID {get;set;}
        /// <summary>
        /// Property used to store NoOfSeatsAvailable <see cref="ScreeningDetails"/>
        /// </summary>
        /// <value></value>
        public int NoOfSeatsAvailable {get;set;}
        /// <summary>
        /// Property used to store TicketPrice <see cref="ScreeningDetails"/>
        /// </summary>
        /// <value></value>
        public double TicketPrice {get;set;}
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="ScreeningDetails"/>
        /// </summary>
        public ScreeningDetails(){}
        /// <summary>
        ///  Parameterized  constructor  used to initialize the class with parameter values <see cref="ScreeningDetails"/>
        /// </summary>
        /// <param name="movieID">movieID is a string used to initialize the property MovieID</param>
        /// <param name="theatreID">theatreID is a string used to initialize the property TheatreID</param>
        /// <param name="noOfSeatsAvailable">noOfSeatsAvailable is a string used to initialize the property NoOfSeatsAvailable</param>
        /// <param name="ticketPrice">ticketPrice is a string used to initialize the property TicketPrice</param>
        /// //parameterized constructor
        public ScreeningDetails(string movieID, string theatreID, int noOfSeatsAvailable, double ticketPrice)
        {
            ScreeningID=$"SID{++s_screenigID}";
            MovieID = movieID;
            TheatreID = theatreID;
            NoOfSeatsAvailable = noOfSeatsAvailable;
            TicketPrice = ticketPrice;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="ScreeningDetails"/>
        /// </summary>
        /// <param name="movieID">movieID is a string used to initialize the property MovieID</param>
        /// <param name="theatreID">theatreID is a string used to initialize the property TheatreID</param>
        /// <param name="noOfSeatsAvailable">oOfSeatsAvailable is a string used to initialize the property oOfSeatsAvailable</param>
        /// <param name="ticketPrice">ticketPrice is a string used to initialize the property TicketPrice</param>
        public ScreeningDetails(string screengID,string movieID, string theatreID, int noOfSeatsAvailable, double ticketPrice)
        {
            ScreeningID=screengID;
            MovieID = movieID;
            TheatreID = theatreID;
            NoOfSeatsAvailable = noOfSeatsAvailable;
            TicketPrice = ticketPrice;
            ++s_screenigID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="ScreeningDetails"/>
        /// </summary>
        /// <param name="details">string value used to initialize constructor during file handlingg</param>
        public ScreeningDetails(string details)
        {
            string[] values =details.Split(',');
            ScreeningID=values[0];
            MovieID = values[1];
            TheatreID = values[2];
            NoOfSeatsAvailable = Convert.ToInt32(values[3]);
            TicketPrice = Convert.ToDouble(values[4]);
            ++s_screenigID;
        }
    }
}