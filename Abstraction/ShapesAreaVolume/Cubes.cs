using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesAreaVolume
{
    public class Cubes :Shape
    {
        //creating the properties for the Cubes 
        public override double Area{get;set;}
        public override double Volume {get;set;}
       //calculating the cube area
        public override double CalculateArea(){
            Area =6*(Math.Pow(Page_a,2));
            return Area;
        }
        //calculating cube volume
        public override double CalculateVolume(){
            Volume =Math.Pow(Page_a,3);
            return Volume;
        }
       //creating default constructor for cubes
        public Cubes(){}
        //creating the parameterized constructor
        public Cubes(double page_a):base(page_a){}
    }
}