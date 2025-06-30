using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineTheatreTicketBooking.Enums;

namespace OnlineTheatreTicketBooking.Models
{
    /// <summary>
    /// PersonalDetails class stores the data of the person <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        //properties
        /// <summary>
        /// Property used to store Name <see cref="PersonalDetails"/>
        /// </summary>
        public string Name {get;set;}
        /// <summary>
        /// Property used to store Age <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public int Age {get;set;}
        /// <summary>
        /// Property used to store PhoneNumberr <see cref="PersonalDetails"/>
        /// </summary>
        public long PhoneNumber {get;set;}
        /// <summary>
        /// Property used to store Gender <see cref="PersonalDetails"/>
        /// </summary>
        public GenderDetails Gender {get;set;}
        //constructors
        /// <summary>
        /// Default constructor used to initialize the empty constructor
        /// </summary>
        public PersonalDetails(){}

    }
}