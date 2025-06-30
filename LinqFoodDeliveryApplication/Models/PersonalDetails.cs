using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineFoodDeliveryApplication.Enums;

namespace OnlineFoodDeliveryApplication.Models
{
    public class PersonalDetails
    {
        //properties
        /// <summary>
        /// Property used to store Name <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string  Name { get; set; }
        /// <summary>
        /// Property used to store Father Name <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string  FatherName { get; set; }
        /// <summary>
        /// Property used to store Gender <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public  GenderDetails Gender {get;set;}
        /// <summary>
        /// Property used to store Mobile Number <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public long Mobile {get;set;}
        /// <summary>
        /// Property used to store DOB <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public DateTime DOB {get;set;}
        /// <summary>
        /// Property used to store MailID<see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string MailID {get;set;}
        /// <summary>
        /// Property used to store Location <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string Location {get;set;}
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="PersonalDetails"/>
        /// </summary>
        public PersonalDetails(){}
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">name is a string used to initialize the property Name</param>
        /// <param name="fatherName">fathername is a string used to initialize the property Father Name</param>
        /// <param name="gender">gender is a Enum used to initialize the property Gender</param>
        /// <param name="mobile">mobileNumber is a string used to initialize the property MobileNumber</param>
        /// <param name="dOB">dob is a date time used to initialize the property DateOfBirth</param>
        /// <param name="mailID">mailID is a Enum used to initialize the property MailID</param>
        /// <param name="location">location is a Enum used to initialize the property Location</param>
        public PersonalDetails(string name, string fatherName, GenderDetails gender, long mobile, DateTime dOB, string mailID, string location)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dOB;
            MailID = mailID;
            Location = location;
        }
    }
}