using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSalaryCalculation
{
    public abstract class PersonalInfo
    {
        //properties
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }
        public GenderDetails Gender { get; set; }
        //constructors
        public PersonalInfo() { }
        public PersonalInfo(string name, string fatherName, string mobileNumber, GenderDetails gender)
        {
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            Gender = gender;
        }
        //creating the abstract
        public abstract string Display();
    }
}