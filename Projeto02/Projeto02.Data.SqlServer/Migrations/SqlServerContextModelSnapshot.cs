﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto02.Data.SqlServer.Contexts;

namespace Projeto02.Data.SqlServer.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    partial class SqlServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projeto02.Domain.Entities.Conta", b =>
                {
                    b.Property<Guid>("IdConta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Categoria")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdConta");

                    b.ToTable("Contas");
                });
#pragma warning restore 612, 618
        }
    }
}