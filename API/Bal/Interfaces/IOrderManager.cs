using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Bal.Interfaces
{
    public interface IOrderManager
    {
        List<string> GetAll();
        Order Find(int id);
        void CreateOrder(Order order);
        void DeleteOrder(int id);
        void UpdateOrder(Order order);
    }
}
