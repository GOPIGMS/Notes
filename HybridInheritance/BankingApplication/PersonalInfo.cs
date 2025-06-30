using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class PersonalInfo
    {
        //getting the properties of PersonalInfo
        public string Name { get; set; }
        public GenderDetails Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        //creating the default constructor
        public PersonalInfo() { }
        //creating parameterized constructor
        public PersonalInfo(string name, GenderDetails gender, DateTime dob, string phone, string mobile)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Mobile = mobile;
        }
    }
}