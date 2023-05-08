using DAL;
using common;
using server.DBModels;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace BL
{
    class ProductsService:IProductsService
    {
        private IProductsRepository repo;
        private IMapper mapper;

        public ProductsService(IProductsRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }


        public List<ProductsVM> GetAll()
        {
            List<TblProducts> tc = repo.GetAll();

            List<ProductsVM> cat = mapper.Map<List<ProductsVM>>(tc);

            return cat;
        }

        public ProductsVM GetById(int id)
        {
            TblProducts cat = repo.GetById(id);
            ProductsVM cvm = mapper.Map<ProductsVM>(cat);

            return cvm;
        }

        public List<ProductsVM> GetByIdCategory(int idCategory)
        {
            List<TblProducts> pro = repo.GetByIdCategory(idCategory);
            List<ProductsVM> lpvm = mapper.Map<List<ProductsVM>>(pro);

            return lpvm;
        }

        public void Delete(int id)
        {

            repo.DeleteProducts(id);
       
        }

        public void Update(ProductsVM ctgry2)
        {
            TblProducts ctgry3 = mapper.Map<TblProducts>(ctgry2);
            repo.UpdateProducts(ctgry3);

        }

        public void Add(ProductsVM ctgry1)
        {
            TblProducts ctgry2 = mapper.Map<TblProducts>(ctgry1);
            repo.AddProducts(ctgry2);
        }
    }
}
