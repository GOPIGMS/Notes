using System;

namespace CollegeAdministration;

class Program
{

    public static void Main(string[] args)
    {
        //performing the operation twice
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Getting the Details of Principle {i + 1}");
            //initializing properties
            Console.WriteLine($"Enter the Principle ID");
            string principleID = Console.ReadLine();
            Console.WriteLine($"Enter the Qualification");
            string qualification = Console.ReadLine();
            Console.WriteLine($"Enter the Year of Experience");
            double yearOfExperience = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the Date Of Joining");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the father name");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the Date of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the Phone Number");
            string phone = Console.ReadLine();
            Console.WriteLine($"Eneter the gender Details :");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine());
            Console.WriteLine($"Enter the mail");
            string mail = Console.ReadLine();
            //creating the objects and displaying the details
            PrincipleInfo principleObject = new PrincipleInfo(principleID, qualification, yearOfExperience, dateOfJoining, name, fatherName, dob, phone, gender, mail);
            Console.WriteLine($"The details are : \n{principleObject.ShowDetails()}");
        }
        //performing opertaion twice for teacher class
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Getting the Details of Teacher Details {i + 1}");
            //initialaizing the properties
            Console.WriteLine($"Enter the Teacher ID");
            string teacherID = Console.ReadLine();
            Console.WriteLine($"Enter the Department");
            string department = Console.ReadLine();
            Console.WriteLine($"Enter the subjectTeaching");
            string subjectTeaching = Console.ReadLine();
            Console.WriteLine($"Enter the qualification");
            string qualification = Console.ReadLine();
            Console.WriteLine($"Enter the Year of Experience");
            double yearOfExperience = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the Date Of Joining");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the father name");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the Date of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the Phone Number");
            string phone = Console.ReadLine();
            Console.WriteLine($"Eneter the gender Details :");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine());
            Console.WriteLine($"Enter the mail");
            string mail = Console.ReadLine();
            //creating the object
            TeacherInfo teacherObject = new TeacherInfo(teacherID, department, subjectTeaching, qualification, yearOfExperience, dateOfJoining, name, fatherName, dob, phone, gender, mail);
            Console.WriteLine($"The details are : \n{teacherObject.ShowDetails()}");
        }
        //performing operation twice for student details
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Getting the Details of Student Details {i + 1}");
            //initializing the properties
            Console.WriteLine($"Enter the Student ID");
            string studentID = Console.ReadLine();
            Console.WriteLine($"Enter the Degree");
            string degree = Console.ReadLine();
            Console.WriteLine($"Enter the Department");
            string department = Console.ReadLine();
            Console.WriteLine($"Enter the Semester");
            string semester = Console.ReadLine();
            Console.WriteLine($"Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the father name");
            string fatherName = Console.ReadLine();
            Console.WriteLine($"Enter the Date of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Enter the Phone Number");
            string phone = Console.ReadLine();
            Console.WriteLine($"Enter the gender Details :");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine());
            Console.WriteLine($"Enter the mail");
            string mail = Console.ReadLine();
            //creating the object 
            StudentInfo studentObject = new StudentInfo(studentID, degree, department, semester, name, fatherName, dob, phone, gender, mail);
            //displaying the details
            Console.WriteLine($"The details are : \n{studentObject.ShowDetails()}");
        }
    }
}