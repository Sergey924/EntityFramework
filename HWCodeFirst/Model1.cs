using System;
using System.Data.Entity;
using System.Linq;

namespace HWCodeFirst
{
    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }
         public virtual DbSet<Person> PersonList { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}