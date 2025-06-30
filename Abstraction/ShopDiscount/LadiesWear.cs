using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDiscount
{
    public class LadiesWear : Dress
    {
        //overriding  properties
        public override DressTypeDetails DressType { get; set; }
        public override string DressName { get; set; }
        public override double Price { get; set; }
        public override double TotalPrice { get; set; }

        //creating constructor
        public LadiesWear() { }
        public LadiesWear(DressTypeDetails dressType, string dressName, double price)
        {
            DressType = dressType;
            DressName = dressName;
            Price = price;
            TotalPrice = price;
        }
        public override string GetDressInfo()
        {
            TotalPrice = Price - Price * 0.2;
            return $"DressType :{DressType},DressName : {DressName},Price : {Price}, TotalPrice : {TotalPrice}";
        }
        public override string DisplayInfo()
        {
            return $"The Bill:\n DressType :{DressType},DressName : {DressName},Price : {Price}, TotalPrice : {TotalPrice}";
        }
    }
}