using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bal.Interfaces;
using System.Threading.Tasks;
using Dal.Interfaces;
using Models.Entities;

namespace Bal.Managers
{
    public class CustomerManager : BaseManager, ICustomerManager
    {
        public CustomerManager(IUnitOfWork uow) : base(uow)
        {

        }
        //Не знаю или будет такое работать
        public List<string> GetAll()
        {
            var customers = new List<string>(new string[] { uow.CustomerRepo.GetAll().ToString() });
            return customers;
        }
        public Customer Find(int id)
        {

            var customer = uow.CustomerRepo.GetByID(id);
            return customer;
        }

        public void CreateCustomer(Customer customer)
        {
            uow.CustomerRepo.Create(customer);
            uow.Save();

        }

        public void DeleteCustomer(int id)
        {
            uow.CustomerRepo.Delete(id);
            uow.Save();
        }

        public void UpdateCustomer(Customer customer)
        {
            uow.CustomerRepo.Update(customer);
            uow.Save();
        }
    }
}
