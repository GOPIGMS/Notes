using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class StudentInfo : PersonalInfo
    {
        //student properties
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        //student default constructor
        public StudentInfo() { }
        //parameterized constructor
        public StudentInfo(string studentID, string degree, string department, string semester, string name, string fatherName, DateTime dob, string phone, GenderDetails gender, string mail) : base(name, fatherName, dob, phone, gender, mail)
        {
            StudentID = studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
        }
        //showing details of student
        public override string ShowDetails()
        {
            return $"\nStudentID : {StudentID},Degree : {Degree}, Department : {Department},Semester : {Semester} {base.ShowDetails()}";
        }
    }
}