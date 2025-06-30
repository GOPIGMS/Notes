using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication.Models
{
    public class ItemsDetails
    {
        //field
        /// <summary>
        ///  Field stores the  _itemID  and auto increment  <see cref="ItemsDetails"/>
        /// </summary>
        private static int _itemID = 4000;
        //properties
        /// <summary>
        /// Property used to store ItemID <see cref="ItemsDetails"/>
        /// </summary>
        public string ItemID { get; set; }
        /// <summary>
        /// Property used to store OrderID <see cref="ItemsDetails"/>
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// Property used to store FoodID <see cref="ItemsDetails"/>
        /// </summary>
        public string FoodID { get; set; }
        /// <summary>
        /// Property used to store Purchase Count <see cref="ItemsDetails"/>
        /// </summary>
        public int PurchaseCount { get; set; }
        /// <summary>
        /// Property used to store PriceOfOrder<see cref="ItemsDetails"/>
        /// </summary>
        public double PriceOfOrder { get; set; }
        //constructors
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="ItemsDetails"/>
        /// </summary>
        public ItemsDetails() { }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="ItemsDetails"/>
        /// </summary>
        /// <param name="itemID">itemID is a string used to initialize the property itemID</param>
        /// <param name="orderID">orderID is a string used to initialize the property orderID</param>
        /// <param name="foodID">foodID is a string used to initialize the property foodID</param>
        /// <param name="purchaseCount">purchaseCount is a int used to initialize the property Purchase Count</param>
        /// <param name="priceOfOrder">priceOfOrder is a double used to initialize the property priceOfOrder </param>
        public ItemsDetails(string itemID, string orderID, string foodID, int purchaseCount, double priceOfOrder)
        {
            ItemID = itemID;
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
            ++_itemID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="ItemsDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public ItemsDetails(string details)
        {
            string[] values = details.Split(',');
            ItemID = values[0];
            OrderID = values[1];
            FoodID = values[2];
            PurchaseCount = Convert.ToInt32(values[3]);
            PriceOfOrder = Convert.ToDouble(values[4]);
            ++_itemID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="ItemsDetails"/>
        /// </summary>
        /// <param name="itemID">itemID is a string used to initialize the property itemID</param>
        /// <param name="orderID">orderID is a string used to initialize the property orderID</param>
        /// <param name="foodID">foodID is a string used to initialize the property foodID</param>
        /// <param name="purchaseCount">purchaseCount is a string used to initialize the property Purchase Count</param>
        /// <param name="priceOfOrder">priceOfOrder is a string used to initialize the property priceOfOrder </param>
        public ItemsDetails(string orderID, string foodID, int purchaseCount, double priceOfOrder)
        {
            ItemID = $"ITID{++_itemID}";
            OrderID = orderID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
    }
}