using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
    public class CylinderCalculator : Calculator
    {
        //overriding the base class objects
        public override void Area(double radius)
        {
            Console.WriteLine($"The area is  {radius * radius * 3.14}");
        }
        public override void Volume(double radius)
        {
            Console.WriteLine($"The Volume is  {radius * radius * 3.14}");
        }
    }
}