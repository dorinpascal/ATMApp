﻿// <auto-generated />
using System;
using GraphQlAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQlAPI.Migrations
{
    [DbContext(typeof(ATMContext))]
    [Migration("20220125133804_DatabaseUpdatex2")]
    partial class DatabaseUpdatex2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("GraphQlAPI.Model.Account", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("GraphQlAPI.Model.Transaction", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Accountid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasColumnType("TEXT");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Accountid");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("GraphQlAPI.Model.Transaction", b =>
                {
                    b.HasOne("GraphQlAPI.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Accountid");

                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
