using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interfaces;
using Models.Entities;
using Dal.Repositories;
namespace Dal
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private AppContext context;
        private IGenericRepository<Product> productRepo;
        private IGenericRepository<Customer> customerRepo;
        private IGenericRepository<Order> orderRepo;
        
        public UnitOfWork()
        {
            context = new AppContext();

            productRepo = new GenericRepository<Product>(context);
            customerRepo = new GenericRepository<Customer>(context);
            orderRepo = new GenericRepository<Order>(context);
            
        }
        public IGenericRepository<Product> ProductRepo
        {
            get
            {
                if (productRepo == null) productRepo = new GenericRepository<Product>(context);
                return productRepo;
            }
        }

        public IGenericRepository<Customer> CustomerRepo
        {
            get
            {
                if (customerRepo == null) customerRepo = new GenericRepository<Customer>(context);
                return customerRepo;
            }
        }

        public IGenericRepository<Order> OrderRepo
        {
            get
            {
                if (orderRepo == null) orderRepo = new GenericRepository<Order>(context);
                return orderRepo;
            }
        }

        
        public void UpdateContext()
        {
            context = new AppContext();
        }
        public void Save()
        {

            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
