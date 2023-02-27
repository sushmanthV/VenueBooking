using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstVenueBooking.Migrations
{
    public partial class CustomerEDmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerEventDetails",
                columns: table => new
                {
                    EventName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    People = table.Column<int>(type: "int", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEventDetails", x => x.EventName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerEventDetails");
        }
    }
}
