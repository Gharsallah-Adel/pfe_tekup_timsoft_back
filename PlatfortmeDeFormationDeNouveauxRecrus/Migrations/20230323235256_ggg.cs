using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatfortmeDeFormationDeNouveauxRecrus.Migrations
{
    public partial class ggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reclamations_Users_UsersUser_id",
                table: "Reclamations");

            migrationBuilder.DropIndex(
                name: "IX_Reclamations_UsersUser_id",
                table: "Reclamations");

            migrationBuilder.DropColumn(
                name: "UsersUser_id",
                table: "Reclamations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersUser_id",
                table: "Reclamations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reclamations_UsersUser_id",
                table: "Reclamations",
                column: "UsersUser_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamations_Users_UsersUser_id",
                table: "Reclamations",
                column: "UsersUser_id",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
