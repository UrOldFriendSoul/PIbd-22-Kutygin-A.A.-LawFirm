﻿// <auto-generated />
using System;
using LawFirmDatabaseImplement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LawFirmDatabaseImplement.Migrations
{
    [DbContext(typeof(LawFirmDatabase))]
    partial class LawFirmDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.DocumentComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("DocumentComponents");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImplement")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponsiblePerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.WarehouseComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("WarehouseComponents");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.DocumentComponent", b =>
                {
                    b.HasOne("LawFirmDatabaseImplement.Models.Component", "Component")
                        .WithMany("DocumentComponents")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LawFirmDatabaseImplement.Models.Document", "Document")
                        .WithMany("DocumentComponents")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");

                    b.Navigation("Document");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Order", b =>
                {
                    b.HasOne("LawFirmDatabaseImplement.Models.Document", "Document")
                        .WithMany("Orders")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.WarehouseComponent", b =>
                {
                    b.HasOne("LawFirmDatabaseImplement.Models.Component", "Component")
                        .WithMany()
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LawFirmDatabaseImplement.Models.Warehouse", "Warehouse")
                        .WithMany("WarehouseComponents")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Component", b =>
                {
                    b.Navigation("DocumentComponents");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Document", b =>
                {
                    b.Navigation("DocumentComponents");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("LawFirmDatabaseImplement.Models.Warehouse", b =>
                {
                    b.Navigation("WarehouseComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
