using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineFoodDeliveryApplication.Enums;

namespace OnlineFoodDeliveryApplication.Models
{
    public class OrderDetails
    {
        //field
        /// <summary>
        /// s_orderID  stores the s_orderID  and auto increment  <see cref="OrderDetails"/>
        /// </summary>
        private static int s_orderID = 3000;
        //properties
        /// <summary>
        /// Property used to store OrderID <see cref="OrderDetails"/>
        /// </summary>
        public string OrderID { get; set; }
        /// <summary>
        /// Property used to store CustomerID  <see cref="OrderDetails"/>
        /// </summary>
        public string CustomerID { get; set; }
        /// <summary>
        /// Property used to store TotalPrice  <see cref="OrderDetails"/>
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property used to store DateOfOrder  <see cref="OrderDetails"/>
        /// </summary>
        public DateTime DateOfOrder { get; set; }
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
        /// <param name="customerID">customerID is a string used to initialize the property CustomerID</param>
        /// <param name="totalPrice">totalPrice is a double used to initialize the property TotalPrice</param>
        /// <param name="dateOfOrder">dateOfOrder is a string used to initialize the property dateOfOrder</param>
        /// <param name="orderStatus">orderStatus is a string used to initialize the property orderStatus</param>
        public OrderDetails(string orderID, string customerID, double totalPrice, DateTime dateOfOrder, OrderStatusDetails orderStatus)
        {
            OrderID = orderID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
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
            CustomerID = values[1];
            TotalPrice = Convert.ToDouble(values[2]);
            DateOfOrder = DateTime.ParseExact(values[3], "dd/MM/yyyy", null);
            OrderStatus = Enum.Parse<OrderStatusDetails>(values[4], true);
            ++s_orderID;
        }
        /// <summary>
        /// Parameterized  constructor  used to initialize the class with parameter values of <see cref="TheatreDetails"/>
        /// </summary>
        /// <param name="customerID">customerID is a string used to initialize the property CustomerID</param>
        /// <param name="totalPrice">totalPrice is a double used to initialize the property TotalPrice</param>
        /// <param name="dateOfOrder">dateOfOrder is a string used to initialize the property dateOfOrder</param>
        /// <param name="orderStatus">orderStatus is a string used to initialize the property orderStatus</param>
        public OrderDetails(string customerID, double totalPrice, DateTime dateOfOrder, OrderStatusDetails orderStatus)
        {
            OrderID = $"OID{++s_orderID}";
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            OrderStatus = orderStatus;
        }
    }
}