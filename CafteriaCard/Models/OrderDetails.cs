using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeteriaCard.Enums;

namespace CafeteriaCard.Models
{
    public class OrderDetails
    {
        //field
        /// <summary>
        /// s_orderID  stores the s_orderID  and auto increment  <see cref="OrderDetails"/>
        /// </summary>
        private static int s_orderID = 1000;
        //properties
        /// <summary>
        /// Property used to store OrderID <see cref="OrderDetails"/>
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// Property used to store CustomerID  <see cref="OrderDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Property used to store OrderDate  <see cref="OrderDetails"/>
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Property used to store TotalPrice  <see cref="OrderDetails"/>
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property used to store OrderStatus  <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public OrderStatusDetails OrderStatus { get; set; }
        //constructor 
        /// <summary>
        /// Default constructor  used to initialize the class <see cref="OrderDetails"/>
        /// </summary>
        public OrderDetails() { }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="orderID">orderID is a string used to initialize the property orderID</param>
        /// <param name="userID">userID is a string used to initialize the property userID</param>
        /// <param name="OrderDate">OrderDate is a string used to initialize the property OrderDate</param>
        /// <param name="totalPrice">totalPrice is a double used to initialize the property TotalPrice</param>
        /// <param name="orderStatus">orderStatus is a string used to initialize the property orderStatus</param>
        public OrderDetails(string orderID, string userID, DateTime orderDate, double totalPrice, OrderStatusDetails orderStatus)
        {
            OrderID = orderID;
            UserID = userID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderStatus = orderStatus;
            ++s_orderID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="details">string with values of all property</param>
        public OrderDetails(string details)
        {
            string[] values = details.Split(',');
            OrderID = values[0];
            UserID = values[1];
            OrderDate = DateTime.ParseExact(values[2], "dd/MM/yyyy", null);
            TotalPrice = Convert.ToDouble(values[1]);
            OrderStatus = Enum.Parse<OrderStatusDetails>(values[4], true);
            ++s_orderID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="orderID">orderID is a string used to initialize the property orderID</param>
        /// <param name="userID">userID is a string used to initialize the property userID</param>
        /// <param name="OrderDate">OrderDate is a string used to initialize the property OrderDate</param>
        /// <param name="totalPrice">totalPrice is a double used to initialize the property TotalPrice</param>
        /// <param name="orderStatus">orderStatus is a string used to initialize the property orderStatus</param>
        public OrderDetails(string userID, DateTime orderDate, double totalPrice, OrderStatusDetails orderStatus)
        {
            OrderID = $"OID{++s_orderID}";
            UserID = userID;
            TotalPrice = totalPrice;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
    }
}