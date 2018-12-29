using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dodos.UI.Migrations {
    public partial class tablesadded : Migration {
        protected override void Up (MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable (
                name: "Departments",
                columns : table => new {
                    DepartmentID = table.Column<int> (type: "int", nullable : false)
                        .Annotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        DepartmentName = table.Column<string> (type: "nvarchar(max)", nullable : false)
                },
                constraints : table => {
                    table.PrimaryKey ("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable (
                name: "Employees",
                columns : table => new {
                    EmployeeID = table.Column<int> (type: "int", nullable : false)
                        .Annotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        DepartmentID = table.Column<int> (type: "int", nullable : true),
                        EmpNo = table.Column<int> (type: "int", nullable : false),
                        EmployeeAddress = table.Column<string> (type: "nvarchar(max)", nullable : true),
                        EmployeeContactNo = table.Column<string> (type: "nvarchar(max)", nullable : true),
                        EmployeeName = table.Column<string> (type: "nvarchar(25)", maxLength : 25, nullable : false)
                },
                constraints : table => {
                    table.PrimaryKey ("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey (
                        name: "FK_Employees_Departments_DepartmentID",
                        column : x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete : ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable (
                name: "Projects",
                columns : table => new {
                    ProjectID = table.Column<int> (type: "int", nullable : false)
                        .Annotation ("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                        ProjectManagerEmployeeID = table.Column<int> (type: "int", nullable : true),
                        ProjectName = table.Column<string> (type: "nvarchar(max)", nullable : false)
                },
                constraints : table => {
                    table.PrimaryKey ("PK_Projects", x => x.ProjectID);
                    table.ForeignKey (
                        name: "FK_Projects_Employees_ProjectManagerEmployeeID",
                        column : x => x.ProjectManagerEmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete : ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex (
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex (
                name: "IX_Projects_ProjectManagerEmployeeID",
                table: "Projects",
                column: "ProjectManagerEmployeeID");
        }

        protected override void Down (MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable (
                name: "Projects");

            migrationBuilder.DropTable (
                name: "Employees");

            migrationBuilder.DropTable (
                name: "Departments");
        }
    }
}