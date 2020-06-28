using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class ChangeFieldLengths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OperatingSystem" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ObtainedFrom" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "MemoryType" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MemorySizeInGb" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HardDriveSizeInGb" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HardDriveBrand" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPU" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Brand" ,
                table: "Computers" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description" ,
                table: "Components" ,
                maxLength: 500 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Capacity" ,
                table: "Components" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand" ,
                table: "Components" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityPort" ,
                table: "Activities" ,
                maxLength: 50 ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityDescription" ,
                table: "Activities" ,
                maxLength: 500 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ActivityAddress" ,
                table: "Activities" ,
                maxLength: 150 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SerialNumber" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OperatingSystem" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ObtainedFrom" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MemoryType" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MemorySizeInGb" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HardDriveSizeInGb" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HardDriveBrand" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPU" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Brand" ,
                table: "Computers" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description" ,
                table: "Components" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Capacity" ,
                table: "Components" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand" ,
                table: "Components" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityPort" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 50 ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityDescription" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityAddress" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldMaxLength: 150);
        }
    }
}