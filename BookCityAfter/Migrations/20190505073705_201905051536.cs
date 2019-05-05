using Microsoft.EntityFrameworkCore.Migrations;

namespace BookCityAfter.Migrations
{
    public partial class _201905051536 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AliaName",
                table: "personnel");

            migrationBuilder.RenameTable(
                name: "personnel",
                newName: "CF_Personnel");

            migrationBuilder.RenameColumn(
                name: "Enable",
                table: "CF_Personnel",
                newName: "isEnable");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "CF_Personnel",
                newName: "AccountNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "CF_Personnel",
                type: "varchar(11)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "CF_Personnel",
                newName: "personnel");

            migrationBuilder.RenameColumn(
                name: "isEnable",
                table: "personnel",
                newName: "Enable");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "personnel",
                newName: "AccountId");

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "personnel",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AliaName",
                table: "personnel",
                type: "varchar(20)",
                nullable: true);
        }
    }
}
