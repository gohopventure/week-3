﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaStore.Storing;

namespace PizzaStore.Storing.Migrations
{
    [DbContext(typeof(PizzaStoreDbContext))]
    partial class PizzaStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaStore.Domain.Models.CrustModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("CrustModel");
                });

            modelBuilder.Entity("PizzaStore.Domain.Models.PizzaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("crustId")
                        .HasColumnType("int");

                    b.Property<int?>("sizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("crustId");

                    b.HasIndex("sizeId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaStore.Domain.Models.SizeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("SizeModel");
                });

            modelBuilder.Entity("PizzaStore.Domain.Models.ToppingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PizzaModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PizzaModelId");

                    b.ToTable("ToppingModel");
                });

            modelBuilder.Entity("PizzaStore.Domain.Models.PizzaModel", b =>
                {
                    b.HasOne("PizzaStore.Domain.Models.CrustModel", "crust")
                        .WithMany()
                        .HasForeignKey("crustId");

                    b.HasOne("PizzaStore.Domain.Models.SizeModel", "size")
                        .WithMany()
                        .HasForeignKey("sizeId");
                });

            modelBuilder.Entity("PizzaStore.Domain.Models.ToppingModel", b =>
                {
                    b.HasOne("PizzaStore.Domain.Models.PizzaModel", null)
                        .WithMany("topping")
                        .HasForeignKey("PizzaModelId");
                });
#pragma warning restore 612, 618
        }
    }
}