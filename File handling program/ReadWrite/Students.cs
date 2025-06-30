using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadWrite
{
    public enum Gender{
        Select,Male,Female,Transgender
    }
    public class Students
    {
        public string Name {get;set;}
        public string FatherName {get;set;}
        public Gender StudentGender {get;set;}
        public DateTime DOB {get;set;}
        public int TotalMarks {get;set;}

        public Students (string name, string fatherName,Gender studentGender,DateTime dob,int totalMarks){
            Name=name;
            FatherName=fatherName;
            StudentGender=studentGender;
            DOB =dob;
            TotalMarks= totalMarks;

        }
        
    }
}