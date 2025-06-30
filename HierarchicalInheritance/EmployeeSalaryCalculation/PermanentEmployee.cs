using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class PermanentEmployee : SalaryInfo
    {
        //creating the properties of the permenent employee class
        public string EmployeeID { get; set; }
        public EmployeeType Employee { get; set; }
        public double TotalSalary { get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        //   double HRA = BasicSalary*0.18;
        //creating the default constructor
        public PermanentEmployee() { }
        // creating the parameterized constructor
        public PermanentEmployee(string employeeID, EmployeeType employee, double basicSalary, int month) : base(basicSalary, month)
        {
            EmployeeID = employeeID;
            Employee = employee;
            HRA = 0.18 * basicSalary;
            DA = 0.2 * basicSalary;
            PF = 0.1 * basicSalary;
        }
        //calculating total salary
        public double CalculateSalary()
        {
            TotalSalary = BasicSalary + HRA + DA - PF;
            return TotalSalary;
        }

    }
}