using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class UpdateComputerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperatingSystem" ,
                table: "Computers" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ObtainedFrom" ,
                table: "Computers" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MemorySizeInGb" ,
                table: "Computers" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HardDriveSizeInGb" ,
                table: "Computers" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPU" ,
                table: "Computers" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormFactor" ,
                table: "Computers" ,
                nullable: false ,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentAsset" ,
                table: "Computers" ,
                nullable: false ,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormFactor" ,
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "IsCurrentAsset" ,
                table: "Computers");

            migrationBuilder.AlterColumn<string>(
                name: "OperatingSystem" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ObtainedFrom" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MemorySizeInGb" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "HardDriveSizeInGb" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CPU" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));
        }
    }
}