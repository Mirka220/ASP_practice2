using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice2.Migrations
{
    /// <inheritdoc />
    public partial class AppDBContextModelSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HomeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNeighbour = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpongeBobFriends",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkinCollor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeId = table.Column<Guid>(name: "Home_Id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpongeBobFriends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpongeBobFriends_Homes_Home_Id",
                        column: x => x.HomeId,
                        principalTable: "Homes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpongeBobFriends_Home_Id",
                table: "SpongeBobFriends",
                column: "Home_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpongeBobFriends");

            migrationBuilder.DropTable(
                name: "Homes");
        }
    }
}
