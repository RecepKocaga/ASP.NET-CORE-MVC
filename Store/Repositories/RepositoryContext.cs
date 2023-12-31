﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace Repositories;
 public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; } //Product modelinde olan alanları Products tablosuna at
        public DbSet<Category> Categories { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) 
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
            .HasData(

                new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 18_000 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 19_000 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 19_000 },
                new Product() { ProductId = 5, ProductName = "Deck", Price = 20_000 }

            );

            modelBuilder.Entity<Category>()
            .HasData(

                new Category() { CategoryId = 1, CategoryName = "Book" },
                new Category() { CategoryId = 2, CategoryName = "Electronik" }

            );

        }
    }