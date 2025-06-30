using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAPI.Controllers 
{
     [ApiController]
     [Route("product")]
    public class FoodController : ControllerBase
    {
         [HttpGet]
        public IActionResult Getproducts(){
            return Ok(DBContext.FoodList);
            
        }
        [HttpGet("{productID}")]
        public IActionResult GetIndividualProduct(int productID)
        {
            var product=DBContext.FoodList.FirstOrDefault(product => product.FoodID == productID);
            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct([FromBody] FoodDetails product)
        {
            product.FoodID=DBContext.FoodList.Count+1;
            DBContext.FoodList.Add(product);
            return Ok();
        }

        [HttpDelete("{productID}")]
        public IActionResult DeleteBook(int productID)
        {
        var product=DBContext.FoodList.FirstOrDefault(product=>product.FoodID==productID);
            if(product==null)
            {
                return NotFound();
            }
            DBContext.FoodList.Remove(product);
            return Ok();
        }

        [HttpPut("{productID}")]
        public IActionResult UpdateProduct(int productID,[FromBody] FoodDetails product)
        {
            var productOld=DBContext.FoodList.Find(product=>product.FoodID==productID);
            if(productOld==null)
            {
                return NotFound();
            }
            // productOld.ProductID=product.ProductID;
            // productOld.ProductName=product.ProductName;
            // productOld.PricePerQuantity=product.PricePerQuantity;
            // productOld.QuantityAvailable=product.QuantityAvailable;
            // productOld.PurchaseDate=product.PurchaseDate;
            // productOld.ExpiryDate=product.ExpiryDate;
            // product.Image=product.Image;
            productOld.FoodID=product.FoodID;
            productOld.FoodName = product.FoodName;
            productOld.PricePerQuantity = product.PricePerQuantity;
            productOld.QuantityAvailable = product.QuantityAvailable;
            return Ok();
        }

        [HttpPut("{productID}/{count}")]
        public IActionResult UpdateCount(int productID,int count)
        {
            var product=DBContext.FoodList.Find(product=>product.FoodID==productID);
            if(product==null)
            {
                return NotFound();
            }
            product.QuantityAvailable-=count;
            return Ok();
        }

    }
}