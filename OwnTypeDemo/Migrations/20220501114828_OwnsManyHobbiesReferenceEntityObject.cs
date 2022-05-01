using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OwnTypeDemo.Migrations
{
    public partial class OwnsManyHobbiesReferenceEntityObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HobbyTypeId",
                table: "Hobby",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "HobbyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobby_HobbyTypeId",
                table: "Hobby",
                column: "HobbyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobby_HobbyTypes_HobbyTypeId",
                table: "Hobby",
                column: "HobbyTypeId",
                principalTable: "HobbyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobby_HobbyTypes_HobbyTypeId",
                table: "Hobby");

            migrationBuilder.DropTable(
                name: "HobbyTypes");

            migrationBuilder.DropIndex(
                name: "IX_Hobby_HobbyTypeId",
                table: "Hobby");

            migrationBuilder.DropColumn(
                name: "HobbyTypeId",
                table: "Hobby");
        }
    }
}
