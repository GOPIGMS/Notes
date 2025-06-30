using System;

namespace CalculatorApp;

class Program
{
    public static void Main(string[] args)
    {
        //creating the circle
        Console.WriteLine($"Enter the circle radius");
        double radius = Convert.ToInt32(Console.ReadLine());
        //creating object
        CircleArea circleAreaObject =new CircleArea(radius);
        Console.WriteLine($"The area of the circle is : {circleAreaObject.CalculateCircleArea()}");
        //calculating the volume of the Cylinder
        Console.WriteLine($"Enter the cylinder height");
        double height =Convert.ToInt32(Console.ReadLine());
        //creating object
        CylinderVolume cylinderVolumeObject =new CylinderVolume(height,radius);
        Console.WriteLine($"The volume of the cylinder is : {cylinderVolumeObject.CalculateVolume()}");
    }
}
