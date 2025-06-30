using System;

namespace StudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        //getting the properties value
        Console.WriteLine($"Enter the StudentID");
        string studentID = Console.ReadLine();
        Console.WriteLine($"Enter the name");
        string name = Console.ReadLine();
        Console.WriteLine($"Enter the Gender");
        GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
        Console.WriteLine($"Enter the mobile");
        string mobile = Console.ReadLine();
        Console.WriteLine($"Enter the DOB");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine($"Enter the physics mark");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the chemistry mark");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the maths mark");
        int maths = Convert.ToInt32(Console.ReadLine());
        //creating object
        StudentInfo studentInfoObject = new StudentInfo(studentID, name, gender, dob, mobile, physics, chemistry, maths);
        Console.WriteLine($"The Total is {studentInfoObject.CalculateTotal()}");
        Console.WriteLine($"The Percentage is {studentInfoObject.CalculatePercentage()}");
        Console.WriteLine($"The details of the students are :\n {studentInfoObject.Display()}");

    }
}