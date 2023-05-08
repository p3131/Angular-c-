using common;
using BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.DBModels;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomersService customers;

        public CustomersController(ICustomersService customers)
        {
            this.customers = customers;
        }

        
        [HttpPut("add")] 
        public List<CustomersVM> AddCustomers([FromBody] CustomersVM cstmr1)
        {
            return customers.Add(cstmr1);
        }

        [HttpGet("check/{name}/{password}")]
        public bool CheckIsExists(string name, string password)
        {
            return customers.Check(name, password);
        }
    }
}
