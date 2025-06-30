using System;

namespace CalculatorManipulation;

class Program
{
    public static void Main(string[] args)
    {
        //creating object for CircleCalculator
        Console.WriteLine($"Enter the Radius for circle");
        double circleRadius = Convert.ToDouble(Console.ReadLine());
        CircleCalculator circleCalculatorObject = new CircleCalculator();
        circleCalculatorObject.Area(circleRadius);
        //creating object for CylinderCalculator
        Console.WriteLine($"Enter the Radius for cylinder");
        double cylinderRadius = Convert.ToDouble(Console.ReadLine());
        CylinderCalculator cylinderCalculatorObject = new CylinderCalculator();
        cylinderCalculatorObject.Area(circleRadius);
    }
}