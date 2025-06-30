using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class IDInfo :PersonalInfo
    {
        //properties of class id
        public string VoterID {get;set;}
        public long AadharID {get;set;}
        public string PANNumber {get;set;}
        //constructor
        public IDInfo(){}
        //parameterized constructor
        public IDInfo(string voterID,long aadharID,string panNmuber,string name,  GenderDetails gender,DateTime dob,string phone, string mobile):base( name,   gender, dob,phone,  mobile){
            VoterID=voterID;
            AadharID=aadharID;
            PANNumber=panNmuber;
        }
    }
}