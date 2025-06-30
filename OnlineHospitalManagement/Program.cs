using System;

namespace OnlineHospitalManagement;

class Program
{
    public static void Main(string[] args)
    {

        try
        {
             //reading the data from csv
             Operations.ReadDataFromCSV();
             //loading the default data for the first time
             //Operations.DefaultData();
             //calling the main menu
             Operations.MainMenu();
             //writing the datas to the file
             Operations.WriteDataToCSV();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Problem is {ex.Message}");
        }
    }
}