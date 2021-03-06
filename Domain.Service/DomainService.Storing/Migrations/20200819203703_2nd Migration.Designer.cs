﻿// <auto-generated />
using System;
using DomainService.Storing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DomainService.Storing.Migrations
{
    [DbContext(typeof(DomainServiceDBContext))]
    [Migration("20200819203703_2nd Migration")]
    partial class _2ndMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainService.Domain.Models.ConstellationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Constellation");
                });

            modelBuilder.Entity("DomainService.Domain.Models.PlanetModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Radius")
                        .HasColumnType("float");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Planet");
                });

            modelBuilder.Entity("DomainService.Domain.Models.PlanetSolarSystJunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlanetId")
                        .HasColumnType("int");

                    b.Property<int?>("SolarSystemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.HasIndex("SolarSystemId");

                    b.ToTable("PlanetSolarSystJunction");
                });

            modelBuilder.Entity("DomainService.Domain.Models.SolarSystemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SolarSystem");
                });

            modelBuilder.Entity("DomainService.Domain.Models.StarConstJunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConstellationId")
                        .HasColumnType("int");

                    b.Property<int?>("StarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConstellationId");

                    b.HasIndex("StarId");

                    b.ToTable("StarConstJunction");
                });

            modelBuilder.Entity("DomainService.Domain.Models.StarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Mass")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Radius")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Star");
                });

            modelBuilder.Entity("DomainService.Domain.Models.PlanetSolarSystJunction", b =>
                {
                    b.HasOne("DomainService.Domain.Models.PlanetModel", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId");

                    b.HasOne("DomainService.Domain.Models.SolarSystemModel", "SolarSystem")
                        .WithMany()
                        .HasForeignKey("SolarSystemId");
                });

            modelBuilder.Entity("DomainService.Domain.Models.StarConstJunction", b =>
                {
                    b.HasOne("DomainService.Domain.Models.ConstellationModel", "Constellation")
                        .WithMany()
                        .HasForeignKey("ConstellationId");

                    b.HasOne("DomainService.Domain.Models.StarModel", "Star")
                        .WithMany()
                        .HasForeignKey("StarId");
                });
#pragma warning restore 612, 618
        }
    }
}
