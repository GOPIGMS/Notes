using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
  public class CircleCalculator : Calculator
  {
    //overriding the method of base class calculator
    public override void Area(double radius)
    {
      Console.WriteLine($"The area is  {radius * radius * -3.14}");
    }
    public override void Volume(double radius)
    {
      Console.WriteLine($"The area is  {radius * radius * -3.14}");
    }
  }
}