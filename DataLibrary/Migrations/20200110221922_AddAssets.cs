using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class AddAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ActivityName" ,
                table: "Activities" ,
                maxLength: 40 ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityDescription" ,
                table: "Activities" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityAddress" ,
                table: "Activities" ,
                nullable: false ,
                oldClrType: typeof(string) ,
                oldType: "longtext CHARACTER SET utf8mb4" ,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Components" ,
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy" , MySqlValueGenerationStrategy.IdentityColumn) ,
                    Description = table.Column<string>(nullable: true) ,
                    Brand = table.Column<string>(nullable: true) ,
                    Capacity = table.Column<string>(nullable: true) ,
                    Type = table.Column<int>(nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components" , x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Computers" ,
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy" , MySqlValueGenerationStrategy.IdentityColumn) ,
                    Brand = table.Column<string>(nullable: true) ,
                    CPU = table.Column<string>(nullable: true) ,
                    Speed = table.Column<string>(nullable: true) ,
                    MemorySizeInGb = table.Column<string>(nullable: true) ,
                    MemoryType = table.Column<string>(nullable: true) ,
                    HardDriveSizeInGb = table.Column<string>(nullable: true) ,
                    HardDriveBrand = table.Column<string>(nullable: true) ,
                    SerialNumber = table.Column<string>(nullable: true) ,
                    ObtainedFrom = table.Column<string>(nullable: true) ,
                    OperatingSystem = table.Column<string>(nullable: true)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers" , x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.AlterColumn<string>(
                name: "ActivityName" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string) ,
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityDescription" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ActivityAddress" ,
                table: "Activities" ,
                type: "longtext CHARACTER SET utf8mb4" ,
                nullable: true ,
                oldClrType: typeof(string));
        }
    }
}