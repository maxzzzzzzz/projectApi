using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Bal.Interfaces
{
    public interface IProductManager
    {
        List<string> GetAll();
        Product Find(int id);
        void CreateProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
    }
}
