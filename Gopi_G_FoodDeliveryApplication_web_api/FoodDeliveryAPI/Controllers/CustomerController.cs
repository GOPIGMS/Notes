using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        //getting user datas
        [HttpGet]
        public IActionResult GetCustomers(){
            return Ok(DBContext.CustomerList);
        }

        [HttpGet("{id}")]
        public IActionResult GetIndividualCustomer(int id)
        {
            var customer = DBContext.CustomerList.FirstOrDefault(user => user.CustomerID == id);
            if(customer==null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

         [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerDetails customer){
            customer.CustomerID = DBContext.CustomerList.Count+1;
            DBContext.CustomerList.Add(customer);
            // you might want to return CreatedAction or Another appropriate resoonce
            return Ok();
        }
        [HttpPut("{customerID}/{amount}")]
        public IActionResult UpdateCount(int customerID,int amount)
        {
            var user=DBContext.CustomerList.FirstOrDefault(user=>user.CustomerID==customerID);
            if(user==null)
            {
                return NotFound();
            }
            user.WalletBalance+=amount;
            return Ok(user);
        }
    }
}