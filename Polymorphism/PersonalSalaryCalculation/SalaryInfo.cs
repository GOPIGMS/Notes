using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSalaryCalculation
{
    public class SalaryInfo : EmployeeInfo
    {
        private int _noOfDaysWorked = 0;
        public int NumberOfDaysWorked { get { return _noOfDaysWorked; } }
        //constructor
        public SalaryInfo() { }
        public SalaryInfo(int noOfWorkingDays, string employeeID, string name, string fatherName, string mobileNumber, GenderDetails gender) : base(employeeID, name, fatherName, mobileNumber, gender)
        {
            _noOfDaysWorked = noOfWorkingDays;
        }
        //creating the methods
        public double CalculateSalary()
        {
            return _noOfDaysWorked * 500;
        }
        public override string Display()
        {
            return $"EmployeeID : {EmployeeID},No of Working Days : {NumberOfDaysWorked},Salary :{CalculateSalary()} , Name : {Name},Father Name : {FatherName},Mobile Number : {MobileNumber},Gender : {Gender}";

        }
    }
}