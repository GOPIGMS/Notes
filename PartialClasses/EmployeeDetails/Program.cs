using System;

namespace EmployeeDetails;

class Program
{
    public static void Main(string[] args)
    {
        //getting the properties value
        Console.WriteLine($"Enter the Employee ID");
        string studentID = Console.ReadLine();
        Console.WriteLine($"Enter the name");
        string name = Console.ReadLine();
        Console.WriteLine($"Enter the Gender");
        GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
        Console.WriteLine($"Enter the DOB");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine($"Enter the mobile");
        string mobile = Console.ReadLine();
        //creating object
        EmployeeInfo employeeInfoObject = new EmployeeInfo(studentID, name, gender, dob, mobile);
        Console.WriteLine($"The details of the students are :\n {employeeInfoObject.Display()}");
    }
}