using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public class Hack : EmployeeInfo
    {
        public string StoreUserID { get; set; }
        public string StorePassword { get; set; }

        public string ShowKeyInfo()
        {
            return $"";
        }
        public string ShowUserInfo()
        {
            return $"Stored User Id : {StoreUserID}, Stored Password : {StorePassword}";
        }
    }
}