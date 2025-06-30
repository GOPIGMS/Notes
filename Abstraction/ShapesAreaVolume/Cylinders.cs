using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesAreaVolume
{
    public class Cylinders :Shape
    {
        //creating the properties for cylinder
        public override double Area{get;set;}
        public override double Volume {get;set;}
        // Calculating the area
        public override double CalculateArea(){
            Area=2*Math.PI*Radius*(Radius+Height);
            return Area;
        }
        //calculting the volume
        public override double CalculateVolume(){
            Volume =Math.PI*Radius*2*Height;
            return Volume;
        }
        //creating the default constructor
        public Cylinders(){}
        //creating the parameterized constructor
        public Cylinders(double radius,double height,double width):base(radius,height,width){

        }


    }
}