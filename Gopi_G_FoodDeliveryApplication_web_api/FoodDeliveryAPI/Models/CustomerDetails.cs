using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryAPI.Models
{
    public class CustomerDetails
    {
        public int CustomerID {get;set;}
        public int WalletBalance {get;set;}
        public string Name {get;set;}
        public string FatherName {get;set;}
        public string Gender {get;set;}
        public string Mobile {get;set;}
        public DateTime DOB {get;set;}
        public string  MailID {get;set;}
        public string Location {get;set;}
        public string Password {get;set;}
    }
}