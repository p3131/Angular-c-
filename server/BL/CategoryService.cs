using System;
using System.Collections.Generic;
using AutoMapper;
using common;
using DAL;
using server.DBModels;

namespace BL
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository repo;
        private IMapper mapper;

        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public List<CategoryVM> GetAll()
        {
            List<TblCategory> tc = repo.GetAll();

            List<CategoryVM> cat = mapper.Map<List<CategoryVM>>(tc);

            return cat;
        }

        public CategoryVM GetById(int id)
        {
            TblCategory cat = repo.GetById(id);

            CategoryVM cvm = mapper.Map<CategoryVM>(cat);

            return cvm;            
        }       

        public List<CategoryVM> Delete(int id)
        {
            List<TblCategory> tc = repo.DeleteCategory(id);

            List<CategoryVM> cat = mapper.Map<List<CategoryVM>>(tc);

            return cat;
        }

        public void Update(CategoryVM ctgry2)
        {
            TblCategory ctgry3 = mapper.Map<TblCategory>(ctgry2);

           repo.UpdateCategory(ctgry3);

        }

        public void Add(CategoryVM ctgry1)
        {
            TblCategory ctgry2 = mapper.Map<TblCategory>(ctgry1);

            repo.AddCategory(ctgry2);

        }
    }
}
