using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public class RegisterPerson : PersonalInfo, IShowData, IFamilyInfo
    {
        //properties of RegisterPerson class
        private static int s_registerNumber { get; set; }
        public int RegisterNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSibling { get; set; }
        //creating the default constructor
        public RegisterPerson() { }
        //parameterized constructor to assigning value and passing value to the base class
        public RegisterPerson(DateTime dateOfRegistration, string fatherName, string motherName, string houseAddress, int noOfSibling, string name, GenderDetails gender, DateTime dob, string phone, string mobile, MaritalDetails maritalStatus) : base(name, gender, dob, phone, mobile, maritalStatus)
        {

            RegisterNumber = ++s_registerNumber;
            DateOfRegistration = dateOfRegistration;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSibling = noOfSibling;
        }
        //showing details
        public override string ShowInfo()
        {
            return $"RegisterNumber {RegisterNumber}, Date Of Registration : {DateOfRegistration}, Father Name : {FatherName}, Mother Name : {MotherName}, HouseAddress : {HouseAddress}, No Of Siblings : {NoOfSibling} \nName : {Name}, Gender : {Gender}, DOB : {DOB}, Phone :{Phone}, Mobile : {Mobile}, MaritalStatus : {MaritalStatus}";
        }
    }
}