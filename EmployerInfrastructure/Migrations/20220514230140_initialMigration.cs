using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployerInfrastructure.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    CreatedUTC = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AccountNumber", "CreatedUTC", "EmployeeName" },
                values: new object[] { 1, "01234550", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "John" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AccountNumber", "CreatedUTC", "EmployeeName" },
                values: new object[] { 2, "56264550", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Local), "Pete" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
