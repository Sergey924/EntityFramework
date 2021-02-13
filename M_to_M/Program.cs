using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_to_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 dataBase = new Model1();

            Product p1 = new Product { Name = "Мандарин", Price = 15 };
            Product p2 = new Product { Name = "Яблоко", Price = 32 };
            Product p3 = new Product { Name = "Огурец", Price = 80 };
            Product p4 = new Product { Name = "Помидор", Price = 110 };

            dataBase.SaveChanges();
            dataBase.Products.AddRange(new List<Product> { p1, p2, p3, p4 });


            Order order1 = new Order { Customer = "Sergey", Quantity = 1 };
            order1.Product.Add(p1);
            order1.Product.Add(p2);
            order1.Product.Add(p4);

            Order order2 = new Order { Customer = "Viktor", Quantity = 2 };
            order2.Product.Add(p1);
            order2.Product.Add(p3);
            order2.Product.Add(p4);

            dataBase.Orders.AddRange(new List<Order> { order1, order2 });
            dataBase.SaveChanges();

            foreach (var itemProd in dataBase.Products.Include(p => p.Order))
            {
                Console.WriteLine("{0}.{1}", itemProd.Id, itemProd.Name);

                if (itemProd.Order == null) continue;

                foreach (var itemOrder in itemProd.Order)
                {
                    Console.WriteLine("{0}.{1}", itemOrder.Id, itemOrder.Customer);
                }
                Console.WriteLine("-----------------------------------------");
            }

            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            foreach (var itemOrder in dataBase.Orders.Include(p => p.Product))
            {
                Console.WriteLine("{0}.{1}", itemOrder.Id, itemOrder.Customer);

                if (itemOrder.Product == null) continue;

                foreach (var itemProd in itemOrder.Product)
                {
                    Console.WriteLine("{0}.{1} - {2}", itemProd.Id, itemProd.Name, itemProd.Price);
                }
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
