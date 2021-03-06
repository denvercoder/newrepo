using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shared.Models;

namespace Server.Data;

public class AppDBContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public AppDBContext(DbContextOptions<AppDBContext> options) :base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        Category[] categoriesToSeed = new Category[3];

        for (int i = 1; i < 4; i++)
        {
            categoriesToSeed[i - 1] = new Category
            {
                CategoryId = i,
                ThumbnailImagePath = "uploads/placeholder.jpg",
                Name = $"Category {i}",
                Description = $"A description of category {i}"
            };
        }

        modelBuilder.Entity<Category>().HasData(categoriesToSeed);
    }
}