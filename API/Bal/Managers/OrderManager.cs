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
    public class OrderManager : BaseManager, IOrderManager
    {
        public OrderManager(IUnitOfWork uow) : base(uow)
        {

        }
        //Не знаю или будет такое работать
        public List<string> GetAll()
        {
            var orders = new List<string>(new string[] { uow.OrderRepo.GetAll().ToString() });
            return orders;
        }
        public Order Find(int id)
        {

            var order = uow.OrderRepo.GetByID(id);
            return order;
        }

        public void CreateOrder(Order order)
        {
            uow.OrderRepo.Create(order);
            uow.Save();

        }

        public void DeleteOrder(int id)
        {
            uow.OrderRepo.Delete(id);
            uow.Save();
        }

        public void UpdateOrder(Order order)
        {
            uow.OrderRepo.Update(order);
            uow.Save();
        }
    }
}
