using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bal.Interfaces;
using Dal.Interfaces;
using Models.Entities;

namespace Bal.Managers
{
    public class ProductManager : BaseManager, IProductManager
    {
        public ProductManager(IUnitOfWork uow) : base(uow)
        {

        }
        //Не знаю или будет такое работать
        public List<string> GetAll()
        {
            var products = new List<string>(new string[] { uow.ProductRepo.GetAll().ToString() });
            return products;
        }
        public Product Find(int id)
        {

            var product = uow.ProductRepo.GetByID(id);
            return product;
        }

        public void CreateProduct(Product product)
        {
            uow.ProductRepo.Create(product);
            uow.Save();

        }

        public void DeleteProduct(int id)
        {
            uow.ProductRepo.Delete(id);
            uow.Save();
        }

        public void UpdateProduct(Product product)
        {
            uow.ProductRepo.Update(product);
            uow.Save();
        }
    }
}
