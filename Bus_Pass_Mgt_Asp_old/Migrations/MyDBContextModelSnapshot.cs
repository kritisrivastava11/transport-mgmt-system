﻿// <auto-generated />
using System;
using Bus_Pass_Mgt_Asp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bus_Pass_Mgt_Asp.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bus_Pass_Mgt_Asp.Models.Bus", b =>
                {
                    b.Property<int>("BID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BusNumber")
                        .HasColumnType("text");

                    b.Property<string>("VisitingAreas")
                        .HasColumnType("text");

                    b.HasKey("BID");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("Bus_Pass_Mgt_Asp.Models.Location", b =>
                {
                    b.Property<int>("LID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.HasKey("LID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Bus_Pass_Mgt_Asp.Models.Student", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("BID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Bus_Pass_Mgt_Asp.Models.User", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GUID")
                        .HasColumnType("text");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PWD")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Services")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("UID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
