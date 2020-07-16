using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RPG.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    FlavorText = table.Column<string>(maxLength: 500, nullable: true),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Proffesion = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItem",
                columns: table => new
                {
                    PlayerItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    IsEquiped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItem", x => x.PlayerItemId);
                    table.ForeignKey(
                        name: "FK_PlayerItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItem_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItem_ItemId",
                table: "PlayerItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItem_PlayerId",
                table: "PlayerItem",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerItem");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
