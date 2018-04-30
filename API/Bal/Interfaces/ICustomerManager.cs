using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Bal.Interfaces
{
    public interface ICustomerManager
    {
        List<Customer> GetAll();
        Customer Find(int id);
        void CreateCustomer(Customer product);
        void DeleteCustomer(int id);
        void UpdateCustomer(Customer product);
    }
}
