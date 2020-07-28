using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RPG.API.Migrations
{
    public partial class PlayerItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerItem_Items_ItemId",
                table: "PlayerItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerItem_Players_PlayerId",
                table: "PlayerItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerItem",
                table: "PlayerItem");

            migrationBuilder.DropColumn(
                name: "IsEquiped",
                table: "PlayerItem");

            migrationBuilder.RenameTable(
                name: "PlayerItem",
                newName: "PlayerItems");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerItem_PlayerId",
                table: "PlayerItems",
                newName: "IX_PlayerItems_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerItem_ItemId",
                table: "PlayerItems",
                newName: "IX_PlayerItems_ItemId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlayerItemId",
                table: "PlayerItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PlayerItems",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsEquipped",
                table: "PlayerItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ItemGuid",
                table: "PlayerItems",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlayerGuid",
                table: "PlayerItems",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerItems",
                table: "PlayerItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItems_Items_ItemId",
                table: "PlayerItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItems_Players_PlayerId",
                table: "PlayerItems",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerItems_Items_ItemId",
                table: "PlayerItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerItems_Players_PlayerId",
                table: "PlayerItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerItems",
                table: "PlayerItems");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlayerItems");

            migrationBuilder.DropColumn(
                name: "IsEquipped",
                table: "PlayerItems");

            migrationBuilder.DropColumn(
                name: "ItemGuid",
                table: "PlayerItems");

            migrationBuilder.DropColumn(
                name: "PlayerGuid",
                table: "PlayerItems");

            migrationBuilder.RenameTable(
                name: "PlayerItems",
                newName: "PlayerItem");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerItems_PlayerId",
                table: "PlayerItem",
                newName: "IX_PlayerItem_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerItems_ItemId",
                table: "PlayerItem",
                newName: "IX_PlayerItem_ItemId");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerItemId",
                table: "PlayerItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsEquiped",
                table: "PlayerItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerItem",
                table: "PlayerItem",
                column: "PlayerItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItem_Items_ItemId",
                table: "PlayerItem",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItem_Players_PlayerId",
                table: "PlayerItem",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
