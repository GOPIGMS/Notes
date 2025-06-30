using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public partial class EmployeeInfo
    {
        //creating the constructors
        //creating default constructors
        public EmployeeInfo() { }
        public EmployeeInfo(string employeeID, string name, GenderDetails gender, DateTime dob, string mobile)
        {
            EmployeeID = employeeID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }

    }
}