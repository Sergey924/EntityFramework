using System;
using System.Data.Entity;
using System.Linq;

namespace M_to_M
{
    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }

 
}