using System;
using System.Numerics;
using System.Runtime.InteropServices;
namespace SemCalculator;

class Program
{
    public static void Main(string[] args)
    {
        //creating the objects
        int[] sem1Marks = { 1, 1, 1, 1, 1, 1 };
        Calculator sem1 = new Calculator(sem1Marks);
        int[] sem2Marks = { 1, 1, 1, 1, 1, 1 };
        Calculator sem2 = new Calculator(sem2Marks);
        int[] sem3Marks = { 1, 1, 1, 1, 1, 1 };
        Calculator sem3 = new Calculator(sem3Marks);
        int[] sem4Marks = { 1, 1, 1, 1, 1, 1 };
        Calculator sem4 = new Calculator(sem4Marks);
        //performing operation and storing
        Calculator result = sem1 + sem2 + sem3 + sem4;
        Console.WriteLine($"Sem Total {result.Total}");
        Console.WriteLine($"Sem Percentage {result.Percentage()} %");
    }

}