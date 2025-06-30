using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTheatreTicketBooking.Models
{
    /// <summary>
    /// TheatreDetails class stores the data of the theatre <see cref="TheatreDetails"/>
    /// </summary>
    public class TheatreDetails
    {
        //fields
        /// <summary>
        /// s_theatreID  stores the s_theatreID  and auto increment  <see cref="TheatreDetails"/>
        /// </summary>
        private static int s_theatreID=3000;
        //properties
        /// <summary>
        ///  Property used to store TheaterID <see cref="TheatreDetails"/>
        /// </summary>
        /// <value></value>
        public string TheatreID {get;set;}
        /// <summary>
        /// Property used to store TheaterName <see cref="TheatreDetails"/>
        /// </summary>
        /// <value></value>
        public string TheatreName {get;set;}
        /// <summary>
        /// Property used to store TheatreLocation <see cref="TheatreDetails"/>
        /// </summary>
        /// <value></value>
        public string TheatreLocation {get;set;} 
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="TheatreDetails"/>
        /// </summary>
        public TheatreDetails(){}
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="theatreID">theatreID is a string used to initialize the property TheatreID</param>
        /// <param name="theatreName">theatreName is a string used to initialize the property TheatreName</param>
        /// <param name="theatreLocation">theatreLocation is a string used to initialize the property TheatreLocation</param>
        public TheatreDetails(string theatreID, string theatreName, string theatreLocation)
        {
            TheatreID = theatreID;
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;
            ++s_theatreID;
        }
        /// <summary>
        ///Parameterized  constructor  used to initialize the class with parameter values <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="details">string value for files</param>
        public TheatreDetails(string details)
        {
            string[] values =details.Split(',');
            TheatreID = values[0];
            TheatreName = values[1];
            TheatreLocation = values[2];
            ++s_theatreID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="theatreName">theatreName is a string used to initialize the property TheatreName</param>
        /// <param name="theatreLocation">theatreLocation is a string used to initialize the property TheatreLocation</param>
        public TheatreDetails( string theatreName, string theatreLocation)
        {
            TheatreID = $"TID{++s_theatreID}";
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;
        }
    }
}