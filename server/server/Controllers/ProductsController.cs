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
    public class ProductsController : ControllerBase
    {
        IProductsService products;

        public ProductsController(IProductsService products)
        {
            this.products = products;
        }

        [HttpGet]
        public List<ProductsVM> GetAll()
        {
            return products.GetAll();
        }

        [HttpGet("{id}")]
        public ProductsVM GetById(int id)
        {
            return products.GetById(id);
        }

        [HttpGet("{idCategory}")]
        public List<ProductsVM> GetByIdCategory(int idCategory)
        {
            return products.GetByIdCategory(idCategory);
        }

        [HttpDelete("delete/{id}")]
        public List<ProductsVM> DeleteProducts(int id)//[FromBody] ProductsVM prdct)
        {
            products.Delete(id);// prdct);
            //if(GetAll()!=null)
                return GetAll();
            //return null;
        }

        [HttpPut("update")]
        public List<ProductsVM> UpdateProducts([FromBody] ProductsVM prdct2)
        {
            products.Update(prdct2);
            return GetAll();
        }

        [HttpPut("add")]
        public List<ProductsVM> AddProducts([FromBody] ProductsVM prdct1)
        {
            products.Add(prdct1);
            return GetAll();

        }


    }
}
