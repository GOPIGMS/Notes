using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
  public class StudentInfo : PersonalInfo
  {
    //cretating the properties for the Student info
    private static int s_registerNumber = 0;
    public int RegisterNumber { get; set; }
    public string Standard { get; set; }
    public string Branch { get; set; }
    public int AcadamicYear { get; set; }
    //default constructor
    public StudentInfo()
    {

    }
    //parameterized constructor with the  Person Object
    public StudentInfo(PersonalInfo obj, string standard, string branch, int acadamicYear) : base(obj.Name, obj.FatherName, obj.Phone, obj.Mail, obj.DOB, obj.Gender)
    {
      RegisterNumber = ++s_registerNumber;
      Standard = standard;
      Branch = branch;
      AcadamicYear = acadamicYear;
    }
    //parameterized constructor with the  Person Object
    public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, GenderDetails gender, string standard, string branch, int acadamicYear) : base(name, fatherName, phone, mail, dob, gender)
    {
      RegisterNumber = ++s_registerNumber;
      Standard = standard;
      Branch = branch;
      AcadamicYear = acadamicYear;
    }

    public string DisplayStudentInfo()
    {
      return $"RegisterNumber : {RegisterNumber}, Standard : {Standard}, Branch : {Branch},Acadamic Year : {AcadamicYear},{DisplayPersonalInfo()} ";
    }
  }
}