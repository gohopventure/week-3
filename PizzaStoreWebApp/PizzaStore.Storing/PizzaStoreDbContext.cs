using Microsoft.EntityFrameworkCore;
using PizzaStore.Domain.Models;

namespace PizzaStore.Storing
{
    public class PizzaStoreDbContext : DbContext
    {
        public DbSet<PizzaModel> Pizzas { get; set; } // create table
        public DbSet<CrustModel> Crusts { get; set; }
        public DbSet<SizeModel> Sizes { get; set; }
        public DbSet<ToppingModel> Toppings { get; set; }




        public PizzaStoreDbContext(DbContextOptions options) : base(options){} // dependency injection
        public PizzaStoreDbContext(){}



        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PizzaModel>().HasKey(e => e.Id); // primary key constraint
            builder.Entity<CrustModel>().HasKey(e => e.Id);
            builder.Entity<SizeModel>().HasKey(e => e.Id);
            builder.Entity<ToppingModel>().HasKey(e => e.Id);
        }
    }
}