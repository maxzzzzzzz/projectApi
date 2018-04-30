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
    public class ProductManager : BaseManager/*, IProductManager*/
    {
        public ProductManager(IUnitOfWork uow) : base(uow)
        {

        }
        //Не знаю или будет такое работать
        public List<Product> GetAll()
        {
            /*var list = uow.ProductRepo.GetAll();
            return (List<Product>)list;*/
            
             /*var products = new List<string>(new string[] { uow.ProductRepo.GetAll().ToString() });
             return products;*/

            List<Product> li = new List<Product>();
            var details = uow.ProductRepo.GetAll().ToList();
            if (details != null)
            {
                Parallel.ForEach(details, x =>
                {
                    Product obj = new Product();
                    obj.Id = x.Id;
                    obj.Name = x.Name;
                    obj.TypeProduct = x.TypeProduct;
                    li.Add(obj);

                });
                return li;
            }
            else
            {
                return li;
            }
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
