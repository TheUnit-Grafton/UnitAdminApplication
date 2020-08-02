using Microsoft.EntityFrameworkCore.Migrations;

namespace UnitAdmin.Migrations
{
    public partial class UpdateCustomUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position" ,
                table: "AspNetUsers" ,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId" ,
                table: "AspNetUserRoles" ,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId" ,
                table: "AspNetUserClaims" ,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppRoleId" ,
                table: "AspNetRoleClaims" ,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_AppUserId" ,
                table: "AspNetUserRoles" ,
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_AppUserId" ,
                table: "AspNetUserClaims" ,
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_AppRoleId" ,
                table: "AspNetRoleClaims" ,
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_AppRoleId" ,
                table: "AspNetRoleClaims" ,
                column: "AppRoleId" ,
                principalTable: "AspNetRoles" ,
                principalColumn: "Id" ,
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_AppUserId" ,
                table: "AspNetUserClaims" ,
                column: "AppUserId" ,
                principalTable: "AspNetUsers" ,
                principalColumn: "Id" ,
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_AppUserId" ,
                table: "AspNetUserRoles" ,
                column: "AppUserId" ,
                principalTable: "AspNetUsers" ,
                principalColumn: "Id" ,
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_AppRoleId" ,
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_AppUserId" ,
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_AppUserId" ,
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_AppUserId" ,
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_AppUserId" ,
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_AppRoleId" ,
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "Position" ,
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppUserId" ,
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "AppUserId" ,
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "AppRoleId" ,
                table: "AspNetRoleClaims");
        }
    }
}
