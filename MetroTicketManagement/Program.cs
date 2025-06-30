using System;

namespace MetroTicketManagement;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Reading from the csv
            Operations.ReadFromFile();
            //creating Default Data
            //Operations.DefaultData();
            //calling the main menu
            Operations.MainMenu();
            //writing to the csv
            Operations.WriteToFile();
        }
        catch (Exception ex)
        {
            //catching the exception
            Console.WriteLine($"The problem is {ex.Message}");
        }
    }
}