using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class UpdatePartsDefinitions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.CreateTable(
                name: "Parts" ,
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy" , MySqlValueGenerationStrategy.IdentityColumn) ,
                    Description = table.Column<string>(maxLength: 500 , nullable: false) ,
                    Brand = table.Column<string>(maxLength: 50 , nullable: true) ,
                    Capacity = table.Column<string>(maxLength: 50 , nullable: true) ,
                    Type = table.Column<int>(nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts" , x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.CreateTable(
                name: "Components" ,
                columns: table => new
                {
                    Id = table.Column<int>(type: "int" , nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy" , MySqlValueGenerationStrategy.IdentityColumn) ,
                    Brand = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4" , maxLength: 50 , nullable: true) ,
                    Capacity = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4" , maxLength: 50 , nullable: true) ,
                    Description = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4" , maxLength: 500 , nullable: false) ,
                    Type = table.Column<int>(type: "int" , nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components" , x => x.Id);
                });
        }
    }
}