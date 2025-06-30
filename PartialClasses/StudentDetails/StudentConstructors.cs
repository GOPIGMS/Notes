using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public partial class StudentInfo
    {
        //creating student Constructors
        //default constructor
        public StudentInfo() { }
        //parameterized constructor
        public StudentInfo(string studentID, string name, GenderDetails gender, DateTime dob, string mobile, int physics, int chemistry, int maths)
        {
            StudentID = studentID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

    }
}