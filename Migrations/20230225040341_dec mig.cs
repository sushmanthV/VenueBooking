using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstVenueBooking.Migrations
{
    public partial class decmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Decorations",
                table: "Decorations");

            migrationBuilder.AlterColumn<string>(
                name: "EventName",
                table: "Decorations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Decorations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decorations",
                table: "Decorations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Decorations",
                table: "Decorations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Decorations");

            migrationBuilder.AlterColumn<string>(
                name: "EventName",
                table: "Decorations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decorations",
                table: "Decorations",
                column: "EventName");
        }
    }
}
