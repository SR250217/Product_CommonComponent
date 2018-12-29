﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Dodos.UI.Models;
using System;

namespace Dodos.UI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180129101656_tablesadded")]
    partial class tablesadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dodos.UI.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentName")
                        .IsRequired();

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Dodos.UI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentID");

                    b.Property<int>("EmpNo");

                    b.Property<string>("EmployeeAddress");

                    b.Property<string>("EmployeeContactNo");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Dodos.UI.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProjectManagerEmployeeID");

                    b.Property<string>("ProjectName")
                        .IsRequired();

                    b.HasKey("ProjectID");

                    b.HasIndex("ProjectManagerEmployeeID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Dodos.UI.Models.Employee", b =>
                {
                    b.HasOne("Dodos.UI.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("Dodos.UI.Models.Project", b =>
                {
                    b.HasOne("Dodos.UI.Models.Employee", "ProjectManager")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectManagerEmployeeID");
                });
#pragma warning restore 612, 618
        }
    }
}
