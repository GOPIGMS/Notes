using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public class PersonalInfo : IShowData
    {
        //getting all the properties
        public string Name { get; set; }
        public GenderDetails Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public MaritalDetails MaritalStatus { get; set; }

        //creating Constructor
        public PersonalInfo() { }

        //parameterized Constructor
        public PersonalInfo(string name, GenderDetails gender, DateTime dob, string phone, string mobile, MaritalDetails maritalStatus)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Mobile = mobile;
            MaritalStatus = maritalStatus;
        }
        //showing details of person
        public virtual string ShowInfo()
        {
            return $"\nName : {Name}, Gender : {Gender}, DOB : {DOB}, Phone :{Phone}, Mobile : {Mobile}, MaritalStatus : {MaritalStatus}";
        }
    }
}