using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitAdmin.Migrations
{
    public partial class AddCustomUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator" ,
                table: "AspNetUsers" ,
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator" ,
                table: "AspNetRoles" ,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator" ,
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator" ,
                table: "AspNetRoles");
        }
    }
}
