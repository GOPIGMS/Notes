using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;
namespace CalculatorApp
{
    public class CircleArea :Maths
    {
        //creating the properties of the circle
        public double Radius {get;set;}
        internal double Area {get;set;}
        //constructors
        public CircleArea(){}
        public CircleArea(double radius){
            Radius =radius;
        }
        //calculateCircleArea
        public double CalculateCircleArea(){
            Area =PI*Radius*Radius;
            return Area;
        }
    }
}