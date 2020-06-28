using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class ChangeActivityType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ActivityType" ,
                table: "Activities" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ActivityType" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(int));
        }
    }
}