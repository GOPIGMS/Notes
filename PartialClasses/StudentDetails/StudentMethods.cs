using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace StudentDetails
{
    public partial class StudentInfo
    {
        //calculating total
        public double CalculateTotal()
        {
            return Physics + Chemistry + Maths;
        }
        //calculating Percentage
        public double CalculatePercentage()
        {
            return CalculateTotal() / 3;
        }
        //Displaying all details
        public string Display()
        {
            return $"StudentID  {StudentID}, Gender : {Gender}, DOB : {DOB}, Mobile : {Mobile}, Physics : {Physics}, Maths : {Maths}, Total : {CalculateTotal()},Percentage : {CalculatePercentage()}";
        }



    }
}