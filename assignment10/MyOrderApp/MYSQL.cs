using MySql.Data.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace OrderApp
{
    public class MYSQL : DbContext
    {
        public MYSQL() : base("OrderApp")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MYSQL>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
 
}
