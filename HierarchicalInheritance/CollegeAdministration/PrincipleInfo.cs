using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PrincipleInfo : PersonalInfo
    {
        // properties
        public string PrincipleID { get; set; }
        public string Qualification { get; set; }
        public double YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        //constructor
        public PrincipleInfo() { }
        public PrincipleInfo(string principleID, string qualification, double yearOfExperience, DateTime dateOfJoining, string name, string fatherName, DateTime dob, string phone, GenderDetails gender, string mail) : base(name, fatherName, dob, phone, gender, mail)
        {
            PrincipleID = principleID;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        //methods
        public override string ShowDetails()
        {
            return $"PrincipleID : {PrincipleID}, Qualification : {Qualification}, YearOfExperience {YearOfExperience},Date Of Joining : {DateOfJoining} {base.ShowDetails()}";
        }

    }
}