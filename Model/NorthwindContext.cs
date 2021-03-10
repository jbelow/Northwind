using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Model
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public void AddCustomer(Customer customer)
        {
            this.Add(customer);
            this.SaveChanges();
        }

    }
}
