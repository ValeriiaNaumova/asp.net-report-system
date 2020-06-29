using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaumovaValeriiaDU2.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Report> Responses { get; set; }
        public DbSet<Message> Requests { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().HasData(
                new Message() { Id = 1, Category = "Electronics", Date = DateTime.Now, Email = "ssss@gmail.com", Product = "Computer", Text = "jjjjj" },
                new Message() { Id = 2, Category = "Electronics", Date = DateTime.Now, Email = "hhh@gmail.com", Product = "Vacuum cleaner", Text = "ooooo" },
                new Message() { Id = 3, Category = "Furniture", Date = DateTime.Now, Email = "marie@gmail.com", Product = "Chair", Text = "Some text" }
                );
            Product prod = new Product { NameOfProduct = "Computer", CategoryId = 1 };
            Product prod1 = new Product { NameOfProduct = "Vacuum Cleaner", CategoryId = 1 };
            Product prod2 = new Product { NameOfProduct = "Chair", CategoryId = 2 };
            modelBuilder.Entity<Product>().HasData(prod, prod1, prod2);
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 1, NameOfCategory = "Electronics" });
            modelBuilder.Entity<Category>().HasData(new Category() { CategoryId = 2, NameOfCategory = "Furniture" });
        }
    }
}
