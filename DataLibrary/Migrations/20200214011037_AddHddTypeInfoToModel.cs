using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class AddHddTypeInfoToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssetTag" ,
                table: "Computers" ,
                maxLength: 20 ,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DriveType" ,
                table: "Computers" ,
                nullable: false ,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetTag" ,
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "DriveType" ,
                table: "Computers");
        }
    }
}