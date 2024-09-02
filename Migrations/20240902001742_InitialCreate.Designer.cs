﻿// <auto-generated />
using APIConcessionaria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace APIConcessionaria.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240902001742_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("APIConcessionaria.EstoqueDeCarros", b =>
                {
                    b.Property<string>("Placa")
                        .HasMaxLength(7)
                        .HasColumnType("character varying(7)");

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("Fipe")
                        .HasColumnType("double precision");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("Quilometragem")
                        .HasColumnType("double precision");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer");

                    b.Property<double>("ValorComprado")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorVenda")
                        .HasColumnType("double precision");

                    b.HasKey("Placa");

                    b.ToTable("EstoqueDeCarros");
                });
#pragma warning restore 612, 618
        }
    }
}
