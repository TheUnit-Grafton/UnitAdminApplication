using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities" ,
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy" , MySqlValueGenerationStrategy.IdentityColumn) ,
                    ActivityName = table.Column<string>(nullable: true) ,
                    ActivityType = table.Column<string>(nullable: true) ,
                    ActivityAddress = table.Column<string>(nullable: true) ,
                    ActivityPort = table.Column<string>(nullable: true) ,
                    IsCurrent = table.Column<bool>(nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities" , x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}