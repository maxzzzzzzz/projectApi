using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
