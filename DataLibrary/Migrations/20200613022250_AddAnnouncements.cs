using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLibrary.Migrations
{
    public partial class AddAnnouncements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements" ,
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy" , MySqlValueGenerationStrategy.IdentityColumn) ,
                    Message = table.Column<string>(nullable: false) ,
                    LinkAddress = table.Column<string>(nullable: true) ,
                    IsCurrent = table.Column<bool>(nullable: false)
                } ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements" , x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");
        }
    }
}