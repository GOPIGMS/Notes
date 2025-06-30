using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetUserInfo
{
    public class PersonalInfo
    {
        //Creating the properties
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public GenderDetails Gender { get; set; }
        //Default Constructor
        public PersonalInfo() { }
        //parameterized constructor
        public PersonalInfo(string name, string fatherName, string mobile, string mail, GenderDetails gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }
        //DisplayingInfo 
        public virtual string DisplayInfo()
        {
            return $"Name : {Name}, FatherName :{FatherName}, Mobile :{Mobile}, Mail :{Mail},Gender : {Gender}";
        }
        public virtual string Update()
        {
            return "";
        }
    }
}