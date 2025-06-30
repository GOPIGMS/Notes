using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace GetUserInfo;

class Program
{
    public static void Main(string[] args)
    {
        //getting the value for object creation
        Console.WriteLine($"Enter the Employee Detail");
        string employeeID = Console.ReadLine();
        Console.WriteLine($"Enter the Date Of Joining");
        DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy", null);
        //creating the object
        EmployeeInfo employeeInfoObject = new EmployeeInfo(employeeID, dateOfJoining);
        employeeInfoObject.DisplayInfo();


    }
}