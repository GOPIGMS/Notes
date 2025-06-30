using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarkSheetGeneration
{
    public class PersonalInfo
    {
        //getting the properties of PersonalInfo
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public GenderDetails Gender { get; set; }
        //creating the default constructor
        public PersonalInfo() { }
        //creating parameterized constructor
        public PersonalInfo(string registerNumber, string name, string fatherName, string phone, DateTime dob, GenderDetails gender)
        {
            RegisterNumber = registerNumber;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }

    }
}