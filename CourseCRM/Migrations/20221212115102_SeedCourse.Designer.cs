﻿// <auto-generated />
using System;
using CourseCRM.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseCRM.Migrations
{
    [DbContext(typeof(CourseContext))]
    [Migration("20221212115102_SeedCourse")]
    partial class SeedCourse
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseCRM.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "dotNet"
                        },
                        new
                        {
                            Id = 3,
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = 4,
                            Name = "React"
                        });
                });

            modelBuilder.Entity("CourseCRM.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Registration")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LeadId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("CourseCRM.Models.Lead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("CourseCRM.Models.Enrollment", b =>
                {
                    b.HasOne("CourseCRM.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseCRM.Models.Lead", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Lead");
                });
#pragma warning restore 612, 618
        }
    }
}