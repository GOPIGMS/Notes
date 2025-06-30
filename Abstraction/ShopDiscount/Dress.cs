using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDiscount
{
    public abstract class Dress
    {
        //creating abstract properties
        public abstract DressTypeDetails DressType { get; set; }
        public abstract string DressName { get; set; }
        public abstract double Price { get; set; }
        public abstract double TotalPrice { get; set; }
        //creating abstract methods
        public abstract string GetDressInfo();
        public abstract string DisplayInfo();


    }
}