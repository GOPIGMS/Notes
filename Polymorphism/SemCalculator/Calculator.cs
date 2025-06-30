using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemCalculator
{
    public class Calculator
    {
        //getting the properties
        private int[] _marks = new int[6];
        private int _result = 0;
        public int Total { get { return _result; } }
        //creating the constructors
        public Calculator() { }
        //parameterized constructor
        public Calculator(int[] semesterMarks)
        {
            _marks = semesterMarks;
            for (int i = 0; i < 6; i++)
            {
                _result += _marks[i];
            }
        }
        //operator overloading
        public static Calculator operator +(Calculator sem1, Calculator sem2)
        {
            Calculator result = new Calculator(new int[6]);
            result._result = sem1._result + sem2._result;
            return result;
        }
        //getting the percentage
        public double Percentage()
        {
            return _result / 24;
        }
    }
}