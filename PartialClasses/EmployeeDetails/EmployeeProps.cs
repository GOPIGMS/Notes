using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public partial class EmployeeInfo
    {
        //creating student Property
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public GenderDetails Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
    }
}