using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PersonalInfo
    {
        //declaring the parameter
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public GenderDetails Gender { get; set; }
        public string Mail { get; set; }
        //constructors
        public PersonalInfo() { }
        public PersonalInfo(string name, string fatherName, DateTime dob, string phone, GenderDetails gender, string mail)
        {
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            Phone = phone;
            Gender = gender;
            Mail = mail;
        }
        //displaying methods
        public virtual string ShowDetails()
        {
            return $"\nName : {Name}, Father Name : {FatherName}, DOB : {DOB}, Phone :{Phone}, Gender : {Gender}, Mail :{Mail}";
        }

    }
}