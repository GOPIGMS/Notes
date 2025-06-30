using System;

namespace EmployeeSalaryCalculation;

class Program
{
    public static void Main(string[] args)
    {
        //looping two times for getting the permanent employee
        for (int i = 0; i < 2; i++)
        {
            //properties are string employeeID,EmployeeType employee,double basicSalary,int month
            Console.WriteLine($"Getting the Details of Permanent Employee {i + 1}");
            //getting the permanent employee Details
            Console.WriteLine($"Enter th Employee ID");
            string employeeID = Console.ReadLine();
            Console.WriteLine($"Enter the Employee Type");
            EmployeeType employee = Enum.Parse<EmployeeType>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the Basic Salary");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());
            PermanentEmployee permanentEmployeeObject = new PermanentEmployee(employeeID, employee, basicSalary, month);
            Console.WriteLine($"The Total Salary is : \n{permanentEmployeeObject.CalculateSalary()}");
        }
        //looping two times for getting the temporary employee
        for (int i = 0; i < 2; i++)
        {
            //properties are string employeeID,EmployeeType employee,double basicSalary,int month
            Console.WriteLine($"Getting the Details of Temporary Employee {i + 1}");
            //getting the permanent employee Details
            Console.WriteLine($"Enter th Employee ID");
            string employeeID = Console.ReadLine();
            Console.WriteLine($"Enter the Employee Type");
            EmployeeType employee = Enum.Parse<EmployeeType>(Console.ReadLine(), true);
            Console.WriteLine($"Enter the Basic Salary");
            double basicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());
            TemporaryEmployee temporaryEmployeeObject = new TemporaryEmployee(employeeID, employee, basicSalary, month);
            Console.WriteLine($"The Total Salary is : \n{temporaryEmployeeObject.CalculateSalary()}");
        }
    }
}