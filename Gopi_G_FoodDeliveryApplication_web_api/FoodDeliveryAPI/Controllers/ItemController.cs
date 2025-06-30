using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAPI.Controllers
{
      [ApiController]
     [Route("item")]
    public class ItemController : ControllerBase
    {
         [HttpGet]
        public IActionResult Getproducts(){
            return Ok(DBContext.ItemList);
            
        }
        [HttpGet("{productID}")]
        public IActionResult GetIndividualProduct(int productID)
        {
            var product=DBContext.ItemList.FirstOrDefault(product => product.ItemID == productID);
            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct([FromBody] ItemDetails product)
        {
            product.ItemID=DBContext.ItemList.Count+1;
            DBContext.ItemList.Add(product);
            return Ok();
        }
                [HttpDelete("{productID}")]
        public IActionResult DeleteBook(int productID)
        {
        var product=DBContext.ItemList.FirstOrDefault(product=>product.ItemID==productID);
            if(product==null)
            {
                return NotFound();
            }
            DBContext.ItemList.Remove(product);
            return Ok();
        }

        
        [HttpPut("{productID}")]
        public IActionResult UpdateProduct(int productID,[FromBody] ItemDetails product)
        {
            var productOld=DBContext.ItemList.Find(product=>product.ItemID==productID);
            if(productOld==null)
            {
                return NotFound();
            }
            productOld.ItemID=product.ItemID;
            productOld.OrderID = product.OrderID;
            productOld.FoodID = product.FoodID;
            productOld.PurchaseCount = product.PurchaseCount;
            productOld.PriceOfOrder = product.PriceOfOrder;
            return Ok();
        }
        
    }
}