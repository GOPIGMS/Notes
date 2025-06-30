using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroTicketManagement.Models
{
    public class TravelDetails
    {
        //fields
        /// <summary>
        ///  Field stores the  s_travelID  and auto increment  <see cref="TravelDetails"/>
        /// </summary>
        private static int s_travelID = 2000;
        //properties
        /// <summary>
        /// Property used to store TravelID <see cref="TravelDetails"/>
        /// </summary>
        public string TravelID { get; set; }
        /// <summary>
        /// Property used to store CardNumber <see cref="TravelDetails"/>
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// Property used to store FromLocation <see cref="TravelDetails"/>
        /// </summary>
        public string FromLocation { get; set; }
        /// <summary>
        /// Property used to store ToLocation <see cref="TravelDetails"/>
        /// </summary>
        public string ToLocation { get; set; }
        /// <summary>
        /// Property used to store TravelDate <see cref="TravelDetails"/>
        /// </summary>
        public DateTime TravelDate { get; set; }
        /// <summary>
        /// Property used to store TravelCost <see cref="TravelDetails"/>
        /// </summary>
        public double TravelCost { get; set; }
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="TravelDetails"/>
        /// </summary>
        public TravelDetails() { }
        //parameterized constructor
        /// <summary>
        ///  Parameterized constructor  used to initialize the class <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="travelID">travelID is a string used to initialize the property travelID</param>
        /// <param name="cardNumber">cardNumber is a string used to initialize the property cardNumber</param>
        /// <param name="fromLocation">fromLocation is a string used to initialize the property fromLocation</param>
        /// <param name="toLocation">toLocation is a string used to initialize the property toLocation</param>
        /// <param name="travelDate">travelDate is a DateTIme used to initialize the property travelDate</param>
        /// <param name="travelCost">travelCost is a double used to initialize the property travelCost</param>
        public TravelDetails(string travelID, string cardNumber, string fromLocation, string toLocation, DateTime travelDate, double travelCost)
        {
            TravelID = travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TravelDate = travelDate;
            TravelCost = travelCost;
            ++s_travelID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public TravelDetails(string details)
        {
            string[] values = details.Split(',');
            TravelID = values[0];
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            TravelDate = DateTime.ParseExact(values[4], "dd/MM/yyyy", null);
            TravelCost = Convert.ToDouble(values[5]);
            ++s_travelID;
        }
        /// <summary>
        ///  Parameterized constructor  used to initialize the class <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="travelID">travelID is a string used to initialize the property travelID</param>
        /// <param name="cardNumber">cardNumber is a string used to initialize the property cardNumber</param>
        /// <param name="fromLocation">fromLocation is a string used to initialize the property fromLocation</param>
        /// <param name="toLocation">toLocation is a string used to initialize the property toLocation</param>
        /// <param name="travelDate">travelDate is a DateTIme used to initialize the property travelDate</param>
        /// <param name="travelCost">travelCost is a double used to initialize the property travelCost</param>
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime travelDate, double travelCost)
        {
            TravelID = $"TID{++s_travelID}";
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TravelDate = travelDate;
            TravelCost = travelCost;
        }
    }
}