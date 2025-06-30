using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo
    {
        //employee info properties
        public string UserID { get; set; }
        public string Password { get; set; }
        public int KeyInfo { get; set; } = 100;
        //constructors
        public EmployeeInfo() { }
        public EmployeeInfo(string userID, string password)
        {
            UserID = userID;
            Password = password;
        }
        public string DisplayInfo()
        {
            return $"UserID : {UserID}, Password : {Password}, keyInfo : {KeyInfo}";
        }


    }
}