using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagementApplication.Enums;

namespace HotelManagementApplication.Models
{
    /// <summary>
    /// Personal Detail class <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        //creating properties
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public long AadharNumber { get; set; }
        public string Address { get; set; }
        public FoodTypeDetails FoodType {get;set;}
        public GenderDetails Gender {get;set;}
        //public PersonalDetails Constructor
        public PersonalDetails(){}
        //parameterized constructor
        public PersonalDetails(string userName, long mobileNumber, long aadharNumber, string address, FoodTypeDetails foodType, GenderDetails gender)
        {
            UserName = userName;
            MobileNumber = mobileNumber;
            AadharNumber = aadharNumber;
            Address = address;
            FoodType = foodType;
            Gender = gender;
        }
    }
}