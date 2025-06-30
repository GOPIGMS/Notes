using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarkSheetGeneration
{
    public class MarkSheet : TheoryExamMarks, ICalculate
    {
        //setting the details for the student marksheet
        public string MarkSheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double TotalMarks { get; set; }
        public double PercentageCalculation { get; set; }
        //creating the object for interface
        public double ProjectMark { get; set; }
        //creating the  default constructors
        public MarkSheet() { }
        //creating parameterized constructor
        public MarkSheet(string markSheetNumber, DateTime dateOfIssue, double projectMark, double[] sem1, double[] sem2, double[] sem3, double[] sem4, string registerNumber, string name, string fatherName, string phone, DateTime dob, GenderDetails gender) : base(sem1, sem2, sem3, sem4, registerNumber, name, fatherName, phone, dob, gender)
        {
            MarkSheetNumber = markSheetNumber;
            DateOfIssue = dateOfIssue;
            ProjectMark = projectMark;
        }
        //adding the total marks of each semester
        public void AddToTotal(double[] array)
        {
            for (int i = 0; i < 6; i++)
            {
                TotalMarks += array[i];
            }
        }
        //adding the total
        public double Total()
        {
            TotalMarks = 0;
            AddToTotal(Sem1);
            AddToTotal(Sem2);
            AddToTotal(Sem3);
            AddToTotal(Sem4);
            return TotalMarks;
        }
        //creating the percentage
        public double Percentage()
        {
            PercentageCalculation = Total() / 24;
            return PercentageCalculation;
        }
        //showing the uG marksheet
        public string ShowUGMarkSheet()
        {
            return $"Personal Info :\nRegistration Number : {RegisterNumber}, Name :{Name}, Father Name : {FatherName},Phone :{Phone},DOB : {DOB},Gender : {Gender}\n Sem1 Marks :{string.Join(", ", Sem1)},\n Sem2 Marks :{string.Join(", ", Sem2)},\n Sem3 Marks :{string.Join(", ", Sem3)},\n Sem4 Marks :{string.Join(", ", Sem4)}\n\nMarksheetNumber : {MarkSheetNumber}, Date Of Issue : {DateOfIssue}, Total :{Total()}, Percentage :{Percentage()}, Project Mark : {ProjectMark}";
        }
    }
}