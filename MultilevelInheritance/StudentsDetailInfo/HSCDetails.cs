using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsDetailInfo
{
    public class HSCDetails : StudentInfo
    {
        //creating the properties for hscdetails class
        private static int s_hscMarkSheetNumber = 0;
        public static int HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double TotalPercentage { get; set; }
        //creating the default constructor
        public HSCDetails() { }
        //creating the parameterized constructor and assign the value and passing the values to the global class
        public HSCDetails(int physics, int chemistry, int maths, int registerNumber, string name, string fatherName, string phone, string mail, DateTime dob, GenderDetails gender, string standard, string branch, int acadamicYear) : base(registerNumber, name, fatherName, phone, mail, dob, gender, standard, branch, acadamicYear)
        {
            HSCMarksheetNumber = ++s_hscMarkSheetNumber;
            Physics = physics;
            Maths = maths;
            Chemistry = chemistry;
        }
        //calculting the total marks
        public int TotalCalculation()
        {
            return Physics + Chemistry + Maths;
        }
        //calculating percentage
        public double PercentageCalculation()
        {
            return TotalCalculation() / 3;
        }
        //showing the mark details
        public string ShowMarkSheet()
        {
            return $"\nHSC MarkSheet number : {HSCMarksheetNumber}, Physics :{Physics},Chemistry :{Chemistry}, Maths :{Maths}\n\nStudent Details:\n {DisplayStudentInfo()}\n\nPersonal Detail:\n {DisplayPersonalInfo()}";
        }
        //getting the marks
        public string GetMarks()
        {
            return $"HSC MarkSheet number : {HSCMarksheetNumber}, Physics :{Physics},Chemistry :{Chemistry}, Maths :{Maths}";
        }
    }
}