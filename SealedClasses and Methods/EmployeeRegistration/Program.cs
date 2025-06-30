using System;

namespace EmployeeRegistration;

class Program {
    public static void Main(string[] args)
    {
        //getting the datas from the user
        Console.WriteLine($"Enter the userID : ");
        string userID =Console.ReadLine();
        Console.WriteLine($"Enter the password :");
        string password =Console.ReadLine();
        EmployeeInfo employeeInfoObject =new EmployeeInfo(userID,password);
        Console.WriteLine($"The user Details are : {employeeInfoObject.DisplayInfo()}");

    }
}
