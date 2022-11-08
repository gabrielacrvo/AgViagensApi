﻿// <auto-generated />
using DestinosApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DestinosApi.Migrations
{
    [DbContext(typeof(DestinoDbContext))]
    [Migration("20221108231008_atuliazarcolunas")]
    partial class atuliazarcolunas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DestinosApi.Model.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("destino");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("uf");

                    b.Property<double>("Valor")
                        .HasColumnType("double")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("destinos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}