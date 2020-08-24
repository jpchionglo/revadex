using System;
using Image.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Image.Storing
{
    public class ImageServiceDBContext : DbContext
    {

      public DbSet<ImageModel> Images { get; set; }

      public ImageServiceDBContext()
      {
      }

      public IConfiguration config { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        if (!optionsBuilder.IsConfigured)
        {
          optionsBuilder.UseSqlServer("Server=revadex.database.windows.net;database=revadex_images;User ID=sqladmin;Password=Password12345");
        }
      }

      public ImageServiceDBContext(DbContextOptions options) : base(options) {}

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<ImageModel>().HasKey(e => e.Id);

        base.OnModelCreating(builder);
      }

    }
}