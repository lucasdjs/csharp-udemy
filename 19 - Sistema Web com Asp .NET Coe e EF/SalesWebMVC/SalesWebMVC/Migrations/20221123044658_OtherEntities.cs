using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BaseSalary = table.Column<double>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SellersRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    SaleStatusId = table.Column<int>(nullable: true),
                    SellerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellersRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellersRecord_SellersRecord_SaleStatusId",
                        column: x => x.SaleStatusId,
                        principalTable: "SellersRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SellersRecord_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_DepartmentId",
                table: "Sellers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SellersRecord_SaleStatusId",
                table: "SellersRecord",
                column: "SaleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SellersRecord_SellerId",
                table: "SellersRecord",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellersRecord");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
