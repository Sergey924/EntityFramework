using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_to_M
{
   public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public List<Product> Product { get; set; }
        public Order()
        {
            Product = new List<Product>();
        }
    }
}
