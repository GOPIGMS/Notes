using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelOnlineLibrary
{
    public class RackInfo : DepartmentDetails
    {
        //creating properties for rackinfo class
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }
        //creating default constructor
        public RackInfo() { }
        //creating parameterized constructor
        public RackInfo(int rackNumber, int columnNumber, string departmentDetails, string degree) : base(departmentDetails, degree)
        {
            RackNumber = rackNumber;
            ColumnNumber = columnNumber;
        }
    }
}