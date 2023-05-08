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
    public class CategoryController : ControllerBase
    {
        ICategoryService category;

        public CategoryController(ICategoryService category)
        {
            this.category = category;
        }

        [HttpGet]
        public List<CategoryVM> GetAll()
        {
            return category.GetAll();
        }

        [HttpGet("{id}")]
        public CategoryVM GetById(int id)
        {
            return category.GetById(id);
        }

        [HttpDelete("delete/{id}")]
        public List<CategoryVM> DeleteCategory(int id)
        {
            return category.Delete(id);
        }

        [HttpPut("update")]
        public List<CategoryVM> UpdateCategory([FromBody] CategoryVM ctgry2)
        {
            category.Update(ctgry2);
            return GetAll();
        }

        [HttpPut("add")] 
        public List<CategoryVM> AddCategory([FromBody] CategoryVM ctgry1)
        {
            category.Add(ctgry1);
            return GetAll();
        }
    }
}
