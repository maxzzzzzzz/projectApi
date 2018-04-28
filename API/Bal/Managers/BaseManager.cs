using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interfaces;

namespace Bal.Managers
{
    public class BaseManager
    {
        protected IUnitOfWork uow;
        public BaseManager(IUnitOfWork UOW)
        {
            this.uow = UOW;
        }
    }
}
