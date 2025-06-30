using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class PersonalInfo
    {
        //creating all the personalInfo Properties
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }
        //creating the  Default constructor
        public PersonalInfo()
        {

        }
        //cretating the parameterized cunstructor
        public PersonalInfo(string name, string fatherName, string phone, string mail, DateTime dob, GenderDetails gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
        //displaying the details
        public string DisplayPersonalInfo()
        {
            return $" Name : {Name} ,FatherName : {FatherName},Phone :{Phone},Mail :{Mail}, Gender :{Gender}";
        }

    }
}