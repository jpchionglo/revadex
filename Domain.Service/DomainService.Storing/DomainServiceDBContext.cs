using System;
using DomainService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DomainService.Storing
{
    public class DomainServiceDBContext : DbContext
    {

      public DbSet<ConstellationModel> Constellation {get;set;}

      public DbSet<PlanetModel> Planet {get;set;}

      public DbSet<SolarSystemModel> SolarSystem {get;set;}

      public DbSet<PlanetSolarSystJunction> PlanetSolarSystJunction {get;set;}

      public DbSet<StarConstJunction> StarConstJunction {get;set;}

      public DbSet<StarModel> Star {get;set;}

      public DomainServiceDBContext(){

        

      }

      public IConfiguration config {get;set;}

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

        if (!optionsBuilder.IsConfigured)
        {

          optionsBuilder.UseSqlServer("Server=revadex.database.windows.net;database=DomainServiceDB;User ID=sqladmin;Password=Password12345");

        }

      }

      public DomainServiceDBContext(DbContextOptions options) : base(options){}

      protected override void OnModelCreating(ModelBuilder builder){

        builder.Entity<ConstellationModel>().HasKey(e => e.Id);
        builder.Entity<PlanetModel>().HasKey(e => e.Id);
        builder.Entity<PlanetSolarSystJunction>().HasKey(e => e.Id);
        builder.Entity<StarConstJunction>().HasKey(e => e.Id);
        builder.Entity<SolarSystemModel>().HasKey(e => e.Id);
        builder.Entity<StarModel>().HasKey(e => e.Id);
        base.OnModelCreating(builder);

      }

    }
}
