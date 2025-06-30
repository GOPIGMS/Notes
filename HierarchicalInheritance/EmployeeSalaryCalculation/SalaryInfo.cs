using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class SalaryInfo
    {
        //creating the salary info property
        public double BasicSalary { get; set; }
        public int Month { get; set; }
        public SalaryInfo() { }
        //creating the parameterized constructor to initialize the value
        public SalaryInfo(double basicSalary, int month)
        {
            BasicSalary = basicSalary;
            Month = month;
        }

    }
}