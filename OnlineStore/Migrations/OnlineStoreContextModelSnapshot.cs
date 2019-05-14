﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Models;

namespace OnlineStore.Migrations
{
    [DbContext(typeof(OnlineStoreContext))]
    partial class OnlineStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineStore.Models.OrderProducts", b =>
                {
                    b.Property<decimal>("OrderId")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal>("ProductId")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("OrderId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("OnlineStore.Models.Orders", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<DateTime>("DeliveredDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("PlacedDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineStore.Models.Users", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(18, 0)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineStore.Models.Orders", b =>
                {
                    b.HasOne("OnlineStore.Models.OrderProducts", "IdNavigation")
                        .WithOne("Orders")
                        .HasForeignKey("OnlineStore.Models.Orders", "Id")
                        .HasConstraintName("FK_Orders_OrderProducts");

                    b.HasOne("OnlineStore.Models.Users", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Orders_Users");
                });
#pragma warning restore 612, 618
        }
    }
}