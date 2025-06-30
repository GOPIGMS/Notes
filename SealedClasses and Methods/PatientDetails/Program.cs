using System;

namespace PatientDetails;

class Program
{

    public static void Main(string[] args)
    {
        //getting the details for the  patient class
        Console.WriteLine($"Enter the paient ID");
        string patientID = Console.ReadLine();
        Console.WriteLine($"Enter the paient Name");
        string patientName = Console.ReadLine();
        Console.WriteLine($"Enter the father Name");
        string fatherName = Console.ReadLine();
        Console.WriteLine($"Enter the Bed No :");
        int bedNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the Native Place");
        string nativePlace = Console.ReadLine();
        Console.WriteLine($"Enter Addmitted for");
        string admittedFor = Console.ReadLine();
        //creating the patient object
        PateintInfo pateintInfoObject = new PateintInfo(patientID, patientName, fatherName, bedNo, nativePlace, admittedFor);
        pateintInfoObject.DisplayInfo();
        //getting the doctor data
        string doctorID = Console.ReadLine();
        Console.WriteLine($"Enter the paient Name");
        string doctorName = Console.ReadLine();
        Console.WriteLine($"Enter the father Name");
        string fatherName1 = Console.ReadLine();
        Console.WriteLine($"Enter the Bed No :");
        DoctorInfo doctorInfoObject = new DoctorInfo(doctorID, doctorName, fatherName1);

    }

}