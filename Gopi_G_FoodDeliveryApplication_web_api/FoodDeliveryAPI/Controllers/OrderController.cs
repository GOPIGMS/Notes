using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("Order")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrder()
        {
            return Ok(DBContext.OrderList);
        }
        [HttpGet("{bookingID}")]
        public List<OrderDetails> GetOrdersByID(int bookingID)
        {
            List<OrderDetails> temporary = new List<OrderDetails>();
            DBContext.OrderList.ToList().ForEach((value) =>
            {
                if (value.OrderID == bookingID)
                {
                    temporary.Add(value);
                }
            });
            return temporary;
        }

        [HttpPost]
        public IActionResult AddOrders([FromBody] OrderDetails order)
        {
            order.OrderID=DBContext.OrderList.Count+1;
            DBContext.OrderList.Add(order);
            return Ok();
        }

        [HttpPut("{productID}")]
        public IActionResult UpdateProduct(int productID,[FromBody] OrderDetails product)
        {
            var productOld=DBContext.OrderList.Find(product=>product.OrderID==productID);
            if(productOld==null)
            {
                return NotFound();
            }
            productOld.OrderID=product.OrderID;
            productOld.CustomerID=product.CustomerID;
            productOld.TotalPrice=product.TotalPrice;
            productOld.DateOfOrder=product.DateOfOrder;
            productOld.OrderStatus=product.OrderStatus;
            return Ok();
        }

        [HttpDelete("{productID}")]
        public IActionResult DeleteBook(int productID)
        {
        var product=DBContext.OrderList.FirstOrDefault(product=>product.OrderID==productID);
            if(product==null)
            {
                return NotFound();
            }
            DBContext.OrderList.Remove(product);
            return Ok();
        }

    }
}