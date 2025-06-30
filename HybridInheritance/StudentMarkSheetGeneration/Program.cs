using System;
using System.Security.Cryptography.X509Certificates;

namespace StudentMarkSheetGeneration;

class Program
{
    public static void Main(string[] args)
    {
        //getting the properties as Input
        Console.WriteLine($"Getting the Details of MarkSheet");
        Console.WriteLine($"Enter the MarkSheet Number");
        string markSheetNumber = Console.ReadLine();
        Console.WriteLine($"Enter the Date Of Issue");
        DateTime dateOfIssue = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.WriteLine($"Enter the Project Mark");
        double projectMark = Convert.ToDouble(Console.ReadLine());
        //getting the sem Marks
        Console.WriteLine($"Enter Sem1 mark");
        double[] sem1 =new double[6];
        sem1=Program.GetArrayData();
        Console.WriteLine($"Enter Sem2 mark");
        double[] sem2 =new double[6];
        sem2=Program.GetArrayData();
        Console.WriteLine($"Enter Sem3 mark");
        double[] sem3 =new double[6];
        sem3=Program.GetArrayData();
        Console.WriteLine($"Enter Sem4 mark");
        double[] sem4 =new double[6];
        sem4=Program.GetArrayData();
        //getting the personal details
        Console.WriteLine($"Enter the  Register Number :");
        string registerNumber =Console.ReadLine();
        Console.WriteLine($"Enter the  name :");
        string name =Console.ReadLine();
        Console.WriteLine($"Enter the  Father Name :");
        string fatherName =Console.ReadLine();
        Console.WriteLine($"Enter the  Phone Number :");
        string phone =Console.ReadLine();
        Console.WriteLine($"Enter the  Date of Birth :");
        DateTime dob =DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.WriteLine($"Enter the  Gender :");
        GenderDetails  gender =Enum.Parse<GenderDetails>(Console.ReadLine(),true);
        MarkSheet markSheetObject = new MarkSheet (markSheetNumber,dateOfIssue,projectMark,sem1,sem2,sem3,sem4,registerNumber,name,fatherName,phone,dob,gender);
        Console.WriteLine($"The Total Marks is : \n{markSheetObject.Total()}");
        Console.WriteLine($"The Total Marks is : \n{markSheetObject.Percentage()}");
        Console.WriteLine($"The Showing UG Marksheet is : \n{markSheetObject.ShowUGMarkSheet()}");
        
    }
    // getting the mark from user
    public static double[] GetArrayData(){
        double[] mark = new double[6];
        for (int i=0;i<6;i++){
            Console.WriteLine($"Enter mark {i+1}");
            mark[i]=Convert.ToDouble(Console.ReadLine());  
        }
        return mark;
    }
}