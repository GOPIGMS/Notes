using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryAPI.Models
{
    public class OrderDetails
    {
        public int OrderID {get;set;}
        public int CustomerID {get;set;}
        public int TotalPrice {get;set;}
        public DateTime DateOfOrder {get;set;}
        public string OrderStatus {get;set;}
    }
}