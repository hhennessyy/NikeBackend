﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20231215004933_Migration1")]
    partial class Migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("OptionName")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("option_name");

                    b.Property<string>("OptionType")
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("option_type");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("option", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Ammount")
                        .HasColumnType("int")
                        .HasColumnName("ammount");

                    b.Property<string>("Comments")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("comments");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("order_status");

                    b.Property<string>("ShippingAddress")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("shipping_address");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CustomerId" }, "customer_fk_idx");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OrderId" }, "order_fk_idx");

                    b.HasIndex(new[] { "ProductId" }, "product_fk_idx");

                    b.ToTable("order_details", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descriptions")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("descriptions");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("image");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.Property<string>("Title")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CategoryId" }, "category_fk_idx");

                    b.HasIndex(new[] { "ProductId" }, "product_fk_idx")
                        .HasDatabaseName("product_fk_idx1");

                    b.ToTable("product_categories", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.ProductOption", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("OptionsId")
                        .HasColumnType("int")
                        .HasColumnName("options_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OptionsId" }, "option_fk_idx");

                    b.HasIndex(new[] { "ProductId" }, "product_fk_idx")
                        .HasDatabaseName("product_fk_idx2");

                    b.ToTable("product_option", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp")
                        .HasColumnName("created");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime")
                        .HasColumnName("expires");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("isActive");

                    b.Property<string>("Revoked")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("revoked");

                    b.Property<string>("Token")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("token");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UserId" }, "userFk_idx");

                    b.ToTable("refresh_token", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("user");

                    b.Property<string>("Password")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("password");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUsuarioFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.HasKey("IdUsuarioFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("RolUsuario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Order", b =>
                {
                    b.HasOne("Dominio.Entities.User", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("customer_fk");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Dominio.Entities.OrderDetail", b =>
                {
                    b.HasOne("Dominio.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("order_fk");

                    b.HasOne("Dominio.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("product_fk");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Dominio.Entities.ProductCategory", b =>
                {
                    b.HasOne("Dominio.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("fk_category");

                    b.HasOne("Dominio.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("fk_product");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Dominio.Entities.ProductOption", b =>
                {
                    b.HasOne("Dominio.Entities.Option", "Options")
                        .WithMany("ProductOptions")
                        .HasForeignKey("OptionsId")
                        .IsRequired()
                        .HasConstraintName("fk_option_product");

                    b.HasOne("Dominio.Entities.Product", "Product")
                        .WithMany("ProductOptions")
                        .HasForeignKey("ProductId")
                        .IsRequired()
                        .HasConstraintName("fk_product_option");

                    b.Navigation("Options");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.HasOne("Dominio.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("user_fk");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dominio.Entities.UserRol", b =>
                {
                    b.HasOne("Dominio.Entities.Rol", "Rol")
                        .WithMany("UserRols")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.User", "User")
                        .WithMany("UserRols")
                        .HasForeignKey("IdUsuarioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dominio.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Dominio.Entities.Option", b =>
                {
                    b.Navigation("ProductOptions");
                });

            modelBuilder.Entity("Dominio.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Dominio.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductCategories");

                    b.Navigation("ProductOptions");
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Navigation("UserRols");
                });

            modelBuilder.Entity("Dominio.Entities.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("RefreshTokens");

                    b.Navigation("UserRols");
                });
#pragma warning restore 612, 618
        }
    }
}
