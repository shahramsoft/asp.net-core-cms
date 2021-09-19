using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shop.API.Models;

namespace Shop.API.Context
{
    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
