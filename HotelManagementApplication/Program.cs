using System;
using System.IO;
using HotelManagementApplication.Models;

namespace HotelManagementApplication;
/// <summary>
/// Program Class Where the execution Starts <see cref="Program"/>
/// </summary>
class Program
{
    //calling the major opertion
    public static void Main(string[] args)
    {
        //wrapping with try catch
        try
        {
            //reading from files
            //Operations.ReadFromFiles();
            //Adding default data
            Operations.DefaultData();
            //calling Main Menu
            Operations.MainMenu();
            //writing to file
            Operations.WriteToFiles();

        }
        catch (Exception ex)
        {
            //printing the exception
          Console.WriteLine($"The problem is {ex.Message}");
        }
    }



}