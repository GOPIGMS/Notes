using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSalaryCalculation
{
    public class EmployeeInfo : PersonalInfo
    {
        //creating the fields and properties 
        private static int s_employeeID = 0;
        public string EmployeeID { get; set; }
        //creating the constructor
        public EmployeeInfo()
        {

        }
        public EmployeeInfo(string employeeID,string name, string fatherName, string mobileNumber, GenderDetails gender) : base(name, fatherName, mobileNumber, gender)
        {
            EmployeeID = employeeID;
        }
        public override string Display()
        {
            return $"EmployeeID : {EmployeeID} , Name : {Name},Father Name : {FatherName},Mobile Number : {MobileNumber},Gender : {Gender}";

        }



    }
}