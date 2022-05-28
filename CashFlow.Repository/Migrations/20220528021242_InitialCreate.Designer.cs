﻿// <auto-generated />
using System;
using CashFlow.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CashFlow.Repository.Migrations
{
    [DbContext(typeof(CashFlowContext))]
    [Migration("20220528021242_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CashFlow.Domain.Entities.PostingEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperationCurrency")
                        .HasColumnType("int");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OperationType")
                        .HasColumnType("int");

                    b.Property<decimal>("OperationValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PostingEntries");
                });
#pragma warning restore 612, 618
        }
    }
}