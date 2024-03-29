﻿// <auto-generated />
using DovizKurlari.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DovizKurlari.Migrations
{
    [DbContext(typeof(MyApplicationContext))]
    partial class MyApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DovizKurlari.Models.InternetKurlari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CaprazKur")
                        .HasColumnType("double precision");

                    b.Property<string>("Doviz")
                        .HasColumnType("text");

                    b.Property<double>("DovizAlis")
                        .HasColumnType("double precision");

                    b.Property<int>("DovizKodu")
                        .HasColumnType("integer");

                    b.Property<double>("DovizSatis")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("InternetKurlari");
                });

            modelBuilder.Entity("DovizKurlari.Models.MarbasPariteleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("AlisParitesi")
                        .HasColumnType("double precision");

                    b.Property<string>("PariteCinsi")
                        .HasColumnType("text");

                    b.Property<double>("SatisParitesi")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("MarbasPariteleri");
                });

            modelBuilder.Entity("DovizKurlari.Models.SerbestKurlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CaprazKur")
                        .HasColumnType("double precision");

                    b.Property<string>("Doviz")
                        .HasColumnType("text");

                    b.Property<double>("DovizAlis")
                        .HasColumnType("double precision");

                    b.Property<int>("DovizKodu")
                        .HasColumnType("integer");

                    b.Property<double>("DovizSatis")
                        .HasColumnType("double precision");

                    b.Property<double>("EfektifAlis")
                        .HasColumnType("double precision");

                    b.Property<double>("EfektifSatis")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("SerbestKurlar");
                });
#pragma warning restore 612, 618
        }
    }
}
