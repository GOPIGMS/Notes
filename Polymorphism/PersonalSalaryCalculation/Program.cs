using System;

namespace PersonalSalaryCalculation;

class Program
{
    public static void Main(string[] args)
    {
        //creating the object for the employee
        EmployeeInfo employeeObject = new EmployeeInfo("1", "Gopi", "Govindaraj", "63838383838", GenderDetails.Male);
        Console.WriteLine($"The details of the employee : {employeeObject.Display()}");
        //creating the salaryInfo Object
        SalaryInfo salaryInfo = new SalaryInfo(10, "1", "Gopi", "Govindaraj", "63838383838", GenderDetails.Male);
        Console.WriteLine($"The salary of the employee is {salaryInfo.CalculateSalary()}");
        Console.WriteLine($"The details of the employee : {salaryInfo.Display()}");

    }
}