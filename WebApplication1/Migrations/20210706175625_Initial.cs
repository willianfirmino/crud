using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paymentdetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "varchar2(100)", maxLength: 100, nullable: false),
                    CardNumber = table.Column<string>(type: "varchar2(16)", maxLength: 16, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "Date", nullable: false),
                    SecurityCode = table.Column<string>(type: "NVARCHAR2(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paymentdetails", x => x.PaymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paymentdetails");
        }
    }
}
