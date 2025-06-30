using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ReadWrite;

class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestData"))
        {
            Console.WriteLine($"Creating the TestData Folder");
            Directory.CreateDirectory("TestData");
        }
        else
        {
            Console.WriteLine($"Folder already present ");

        }
        if (!File.Exists("TestData/Data.csv"))
        {
            Console.WriteLine($"Creating the TestData Folder");
            File.Create("TestData/Data.csv").Close();
        }
        else
        {
            Console.WriteLine($"File  already present ");

        }
        if (!File.Exists("TestData/JsonData.json"))
        {
            Console.WriteLine($"Creating the TestData Folder");
            File.Create("TestData/JsonData.json").Close();
        }
        else
        {
            Console.WriteLine($"File  already present ");

        }
        List<Students> students = new List<Students>();
        students.Add(new Students("Gopi", "Govindarj", Gender.Male, new DateTime(2002, 04, 26), 400));
        students.Add(new Students("Gokul", "Govindarj", Gender.Male, new DateTime(2005, 04, 23), 400));
        WriteToCSV(students);
        Console.WriteLine($"Data written");
        ReadCSV();
        WriteToJson(students);
        ReadJson();
    }
    static void WriteToCSV(List<Students> students)
    {
        StreamWriter sw = new StreamWriter("TestData/Data.csv");
        foreach (Students student in students)
        {
            string line = student.Name + "," + student.FatherName + "," + student.StudentGender + "," + student.DOB.ToString("dd/MM/yyyy") + "," + student.TotalMarks;
            sw.WriteLine(line);
        }
        sw.Close();
    }
    static void ReadCSV(){
        List<Students> students =new List<Students>();
        StreamReader sr = new StreamReader("TestData/Data.csv");
        string line =sr.ReadLine();
        while(line!=null){
            string [] values =line.Split(',');
            if(values[0]!=" "){
                Students student = new Students(values[0],values[1],Enum.Parse<Gender>(values[2]),DateTime.ParseExact(values[3],"dd/MM/yyyy",null),Convert.ToInt32(values[4]));
                students.Add(student);
            }
            line=sr.ReadLine();
        }
        sr.Close();
        foreach(Students student in students){
            Console.WriteLine($"Name : {student.Name}, FatherName : {student.FatherName} Gender :{student.StudentGender} DOB :{student.DOB},Total marks : {student.TotalMarks}"); 
        }
    
    }
    static void WriteToJson(List<Students> students){
        StreamWriter sw = new StreamWriter("TestData/JsonData.json");
        var option =new JsonSerializerOptions{
                 WriteIndented=true
        };
        string jsonData =JsonSerializer.Serialize(students,option);
        sw.WriteLine(jsonData);
        sw.Close();
    }
    static void ReadJson(){
        List<Students> students = JsonSerializer.Deserialize<List<Students>>(File.ReadAllText("TestData/JsonData.json"));
        foreach (Students student in students){
             Console.WriteLine($"Name : {student.Name}, FatherName : {student.FatherName} Gender :{student.StudentGender} DOB :{student.DOB},Total marks : {student.TotalMarks}");       
        }
    }

}