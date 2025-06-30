using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        //creating the properties
        protected internal double PI = 3.14;
        internal double g = 9.8;
        //creating the constructor
        public Maths(){}
        //creating the method
        public double CalculateWeight(double weight)
        {
            return weight * g;
        } 
    }
}