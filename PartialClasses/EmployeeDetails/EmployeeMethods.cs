using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public partial class EmployeeInfo
    {
        //updating the user
        public string Update()
        {
            return $"";
        }
        //display User
        public string Display()
        {
            return $"EmployeeID :{EmployeeID}, Name : {Name},Gender :{Gender}, DOB  : {DOB},Mobile :{Mobile}";
        }

    }
}