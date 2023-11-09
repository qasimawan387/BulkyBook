using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Description = "It is about the fortune of time.",
                    ISBN = "SWD9999001",
                    Author = "Billy Spark",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                 new Product
                 {
                     Id = 2,
                     Title = "War and Peace",
                     Description = "It is about the importance of Peace and why we should avoid from war zone.",
                     ISBN = "SWD9999002",
                     Author = "Leo Tolstoy",
                     ListPrice = 100,
                     Price = 95,
                     Price50 = 90,
                     Price100 = 85,
                     CategoryId = 3,
                     ImageUrl = ""
                 },
                 new Product
                 {
                     Id = 3,
                     Title = "Harry Potter and the Philosopher's Stone",
                     Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling.",
                     ISBN = "SWD9999003",
                     Author = "J. K. Rowling",
                     ListPrice = 150,
                     Price = 140,
                     Price50 = 130,
                     Price100 = 120,
                     CategoryId = 3,
                     ImageUrl = ""
                 }
            );
        }
    }
}