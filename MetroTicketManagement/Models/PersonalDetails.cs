using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroTicketManagement.Models
{
    public class PersonalDetails
    {
        //properties
        /// <summary>
        /// Property used to store UserName <see cref="PersonalDetails"/>
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Property used to store PhoneNumber <see cref="PersonalDetails"/>
        /// </summary>
        public long PhoneNumber {get;set;}
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="PersonalDetails"/>
        /// </summary>
        public PersonalDetails(){}

    }
}