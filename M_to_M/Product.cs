using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_to_M
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Order> Order { get; set; }
        public Product()
        {
            Order = new List<Order>();
        }
    }
}
