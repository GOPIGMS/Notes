using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Controllers
{
    public static class DBContext
    {
        public static  List<CustomerDetails> CustomerList = new List<CustomerDetails>();
        public static List<FoodDetails> FoodList = new List<FoodDetails>();
        public static List<OrderDetails> OrderList = new List<OrderDetails>();
        public static List<ItemDetails> ItemList = new List<ItemDetails>();
    }
}