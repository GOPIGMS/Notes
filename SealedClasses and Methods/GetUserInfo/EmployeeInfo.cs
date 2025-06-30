using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetUserInfo
{
    public class EmployeeInfo : FamilyInfo
    {
        //declaring the property
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }
        //Default Constructor
        public EmployeeInfo() { }
        public EmployeeInfo(string employeeID, DateTime dateOfJoining)
        {
            EmployeeID = employeeID;
            DateOfJoining = dateOfJoining;
        }
        public override string Update()
        {
            return "";
        }
        public override string DisplayInfo()
        {
            return "";
        }
    }
}