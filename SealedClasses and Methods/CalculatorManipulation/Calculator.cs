using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
    public abstract class Calculator
    {
        //creating the abstract method
        public abstract void Area(double radius);
        public abstract void Volume(double radius);
    }
}