using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Dal.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Product> ProductRepo { get; }
        IGenericRepository<Customer> CustomerRepo { get; }
        IGenericRepository<Order> OrderRepo { get; }
        
        void Save();
        void Dispose();
    }
}
