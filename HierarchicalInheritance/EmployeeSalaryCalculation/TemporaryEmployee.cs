using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class TemporaryEmployee : SalaryInfo
    {
        //creating the properties of the Temporatry employee class
        public string EmployeeID { get; set; }
        public EmployeeType Employee { get; set; }
        public double TotalSalary { get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        //   double HRA = BasicSalary*0.18;
        //creating the default constructor
        public TemporaryEmployee() { }
        // creating the parameterized constructor
        public TemporaryEmployee(string employeeID, EmployeeType employee, double basicSalary, int month) : base(basicSalary, month)
        {
            EmployeeID = employeeID;
            Employee = employee;
            HRA = 0.13 * basicSalary;
            DA = 0.15 * basicSalary;
            PF = 0.1 * basicSalary;
        }
        //calculating the total salary and returning the total salary
        public double CalculateSalary()
        {
            TotalSalary = BasicSalary + HRA + DA - PF;
            return TotalSalary;

        }
    }
}