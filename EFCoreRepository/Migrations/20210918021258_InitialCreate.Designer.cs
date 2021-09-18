﻿// <auto-generated />
using System;
using EFCoreRepository.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreRepository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210918021258_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.POCOEntities.BusinessEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusinessEntities");
                });

            modelBuilder.Entity("Entities.POCOEntities.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BusinessEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<byte>("DiscountType")
                        .HasColumnType("tinyint");

                    b.Property<int>("IdBusinessEntity")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("ShippingType")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("BusinessEntityId");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("Entities.POCOEntities.Orden_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrdenId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.ToTable("Orden_Details");
                });

            modelBuilder.Entity("Entities.POCOEntities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.POCOEntities.Orden", b =>
                {
                    b.HasOne("Entities.POCOEntities.BusinessEntity", "BusinessEntity")
                        .WithMany()
                        .HasForeignKey("BusinessEntityId");

                    b.Navigation("BusinessEntity");
                });

            modelBuilder.Entity("Entities.POCOEntities.Orden_Detail", b =>
                {
                    b.HasOne("Entities.POCOEntities.Orden", "Orden")
                        .WithMany("Orden_Details")
                        .HasForeignKey("OrdenId");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("Entities.POCOEntities.Orden", b =>
                {
                    b.Navigation("Orden_Details");
                });
#pragma warning restore 612, 618
        }
    }
}