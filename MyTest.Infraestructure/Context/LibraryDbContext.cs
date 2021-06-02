using Microsoft.EntityFrameworkCore;
using MyTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Infraestructure.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            var user = new User
            {
                UserId = 1,
                FirstName = "Edwin",
                LastName = "Chavarria"
            };

            modelBuilder.Entity<User>().HasData(user);
        }
    }
}
