using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarkSheetGeneration
{
    public interface ICalculate
    {
        //creating the properties for ICalculate interface
        double ProjectMark {get;set;}
        //declaring the methods 
        public double Total();
        public double Percentage();

        
    }
}