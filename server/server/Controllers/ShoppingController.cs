using common;
using BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.DBModels;
using DAL.DBModels_;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        IShoppingService shopping;

        public ShoppingController(IShoppingService shopping)
        {
            this.shopping = shopping;
        }

        [HttpPut("{customerId}")]
        public void AddShop(int customerId, [FromBody] List<ShoppingCart> shoppingCart)
        {
            shopping.AddShop(customerId, shoppingCart);
        }

    }
}
