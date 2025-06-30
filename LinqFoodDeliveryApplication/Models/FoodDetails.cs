using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication.Models
{
    public class FoodDetails
    {
        //field
        /// <summary>
        ///  Field stores the  s_foodID  and auto increment  <see cref="FoodDetails"/>
        /// </summary>
        private static int s_foodID = 2000;
        //properties
        /// <summary>
        /// Property used to store FoodID <see cref="FoodDetails"/>
        /// </summary>
        public string FoodID { get; set; }
        /// <summary>
        /// Property used to store FoodName <see cref="FoodDetails"/>
        /// </summary>
        public string FoodName { get; set; }
        /// <summary>
        /// Property used to store PricePerQuantity <see cref="FoodDetails"/>
        /// </summary>
        public double PricePerQuantity { get; set; }
        /// <summary>
        /// Property used to store QuantityAvailable <see cref="FoodDetails"/>
        /// </summary>
        public int QuantityAvailable { get; set; }
        //constructor
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="FoodDetails"/>
        /// </summary>
        public FoodDetails() { }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="foodID">foodID is a string used to initialize the property foodID</param>
        /// <param name="foodName">foodName is a string used to initialize the property foodName</param>
        /// <param name="pricePerQuantity">pricePerQuantity is a double used to initialize the property pricePerQuantity</param>
        /// <param name="quantityAvailable">quantityAvailable is a string used to initialize the property quantityAvailable</param>
        public FoodDetails(string foodID, string foodName, double pricePerQuantity, int quantityAvailable)
        {
            FoodID = foodID;
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable = quantityAvailable;
            ++s_foodID;
        }
         /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public FoodDetails(string details)
        {
            string[] values = details.Split(',');
            FoodID = values[0];
            FoodName = values[1];
            PricePerQuantity = Convert.ToDouble(values[2]);
            QuantityAvailable = Convert.ToInt32(values[3]);
            ++s_foodID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="FoodDetails"/>
        /// </summary>
        /// <param name="foodID">foodID is a string used to initialize the property foodID</param>
        /// <param name="foodName">foodName is a string used to initialize the property foodName</param>
        /// <param name="pricePerQuantity">pricePerQuantity is a double used to initialize the property pricePerQuantity</param>
        /// <param name="quantityAvailable">quantityAvailable is a string used to initialize the property quantityAvailable</param>
        public FoodDetails(string foodName, double pricePerQuantity, int quantityAvailable)
        {
            FoodID = $"FID{++s_foodID}";
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable = quantityAvailable;
        }
    }
}