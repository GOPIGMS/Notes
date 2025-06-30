using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class TeacherInfo : PersonalInfo
    {
        //parameters of teacher
        public string TeacherID { get; set; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public double YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        //creating default constructor
        public TeacherInfo() { }
        //creating parameterized constructor
        public TeacherInfo(string teacherID, string department, string subjectTeaching, string qualification, double yearOfExperience, DateTime dateOfJoining, string name, string fatherName, DateTime dob, string phone, GenderDetails gender, string mail) : base(name, fatherName, dob, phone, gender, mail)
        {
            TeacherID = teacherID;
            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        //showing details of teacher
        public override string ShowDetails()
        {
            return $"\n TeacherID : {TeacherID}, Department : {Department}, SubjectTeaching : {SubjectTeaching}, Qualification : {Qualification}, Year Of Experience : {YearOfExperience}, Date Of Joining : {DateOfJoining} {base.ShowDetails()}";
        }


    }
}