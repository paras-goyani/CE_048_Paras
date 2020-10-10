using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace temp.Models
{
    public class Order
    {

        public int id { get; set; }
        public DateTime OrderDate { get; set; }
        public double Amount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
