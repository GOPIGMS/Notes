using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ShapesAreaVolume
{
    public abstract class Shape
    {
        //creating the properties of shape as base class
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Page_a { get; set; }
        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        //creating the default constructor
        public Shape()
        {

        }
        //creating the parameterized constructor
        public Shape(double radius, double height, double width)
        {
            Radius = radius;
            Height = height;
            Width = width;
        }
        // creating the Shape object for cube
        public Shape(double page_a)
        {
            Page_a = page_a;
        }

    }


}