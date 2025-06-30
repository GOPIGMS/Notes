using System;

namespace OnlineTheatreTicketBooking;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            //Reading from the csv
            Operations.ReadFromFile();
            //creating Default Data and loaded 
            //Operations.DefaultData();
            //calling the main menu
            Operations.MainMenu();
            //writing to the csv
            Operations.WriteToFile();
        }
        //catching exception
        catch (Exception ex)
        {
            Console.WriteLine($"The problem is {ex.Message}");
        }
    }
}