using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelOnlineLibrary
{
    public class DepartmentDetails
    {
        //creating the properties for departmentdetails class
        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        //creating the default constructor
        public DepartmentDetails() { }
        //creating the parameterized constructor and assigning the value
        public DepartmentDetails(string departmentName, string degree)
        {
            DepartmentName = departmentName;
            Degree = degree;

        }
    }
}