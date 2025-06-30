using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume :CircleArea
    {
        //properties
        private double _height ;
        public double Height {get{return _height;}}
        internal double Volume {get;set;}
        //constructors
        public CylinderVolume(){}
        //parametrized constructor
        public CylinderVolume(double height,double radius):base(radius){
           _height=height;
        }
        //calculating volume
        public double CalculateVolume(){
            Volume =CalculateCircleArea()*Height;
            return Volume;
        }
    }
}