using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarkSheetGeneration
{
    public class TheoryExamMarks :PersonalInfo
    {
        //creating the array properties of the exam class
        public double[] Sem1 {get;set;} =new double[6];
        public double[] Sem2 {get;set;}=new double[6];
        public double[] Sem3 {get;set;}= new double[6];
        public double[] Sem4 {get;set;} = new double[6];
        //creating the default constructor
        public TheoryExamMarks(){}
        //creating the parameter constuctor
        public TheoryExamMarks(double[] sem1,double[] sem2,double[] sem3,double[] sem4,string registerNumber, string name, string fatherName, string phone, DateTime dob, GenderDetails gender):base(registerNumber,name,  fatherName,phone,dob,gender){
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }

    }
}