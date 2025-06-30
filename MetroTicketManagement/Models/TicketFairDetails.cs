using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroTicketManagement.Models
{
    public class TicketFairDetails
    {
        //field
        /// <summary>
        ///  Field stores the  s_ticketID  and auto increment  <see cref="TicketFairDetails"/>
        /// </summary>
        private static int s_ticketID = 3000;
        //fields
        /// <summary>
        /// Property used to store TicketID <see cref="TicketFairDetails"/>
        /// </summary>
        public string TicketID { get; set; }
        /// <summary>
        /// Property used to store FromLocation <see cref="TicketFairDetails"/>
        /// </summary>
        public string FromLocation { get; set; }
        /// <summary>
        /// Property used to store ToLocation <see cref="TicketFairDetails"/>
        /// </summary>
        public string ToLocation { get; set; }
        /// <summary>
        /// Property used to store TicketPrice <see cref="TicketFairDetails"/>
        /// </summary>
        public double TicketPrice { get; set; }
        //constructors
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="TicketFairDetails"/>
        /// </summary>
        public TicketFairDetails() { }
        //parameterized constructors
        /// <summary>
        ///  Parameterized constructor  used to initialize the class <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="ticketID">ticketID is a string used to initialize the property ticketID</param>
        /// <param name="fromLocation">fromID is a string used to initialize the property fromID</param>
        /// <param name="toLocation">toLocation is a string used to initialize the property toLocation</param>
        /// <param name="ticketPrice">ticketPrice is a double used to initialize the property ticketPrice</param>
        public TicketFairDetails(string ticketID, string fromLocation, string toLocation, double ticketPrice)
        {
            TicketID = ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
            ++s_ticketID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public TicketFairDetails(string details)
        {
            string[] values = details.Split(',');
            TicketID = values[0];
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = Convert.ToDouble(values[3]);
            ++s_ticketID;
        }
        //parameterized constructors
        /// <summary>
        ///  Parameterized constructor  used to initialize the class <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="ticketID">ticketID is a string used to initialize the property ticketID</param>
        /// <param name="fromLocation">fromID is a string used to initialize the property fromID</param>
        /// <param name="toLocation">toLocation is a string used to initialize the property toLocation</param>
        /// <param name="ticketPrice">ticketPrice is a double used to initialize the property ticketPrice</param>
        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            TicketID = $"MR{++s_ticketID}";
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;

        }
    }
}