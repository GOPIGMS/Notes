using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryAPI.Models
{
    public class FoodDetails
    {
        public int FoodID {get;set;}
        public string FoodName {get;set;}
        public int PricePerQuantity {get;set;}
        public int QuantityAvailable {get;set;}
    }
}