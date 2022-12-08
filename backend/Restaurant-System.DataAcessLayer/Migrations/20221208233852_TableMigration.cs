using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantSystem.DataAcessLayer.Migrations
{
    /// <inheritdoc />
    public partial class TableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Restaurants_RestaurantId",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_RestaurantId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Tables");

            migrationBuilder.RenameColumn(
                name: "NumberOfTable",
                table: "Tables",
                newName: "NumberOfSeats");

            migrationBuilder.RenameColumn(
                name: "NumberOfSits",
                table: "Tables",
                newName: "IsReserved");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tables",
                newName: "IdRoom");

            migrationBuilder.AlterColumn<int>(
                name: "IdRoom",
                table: "Tables",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "IdTable",
                table: "Tables",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "IdRestaurant",
                table: "Tables",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "IdTable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "IdTable",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "IdRestaurant",
                table: "Tables");

            migrationBuilder.RenameColumn(
                name: "NumberOfSeats",
                table: "Tables",
                newName: "NumberOfTable");

            migrationBuilder.RenameColumn(
                name: "IsReserved",
                table: "Tables",
                newName: "NumberOfSits");

            migrationBuilder.RenameColumn(
                name: "IdRoom",
                table: "Tables",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Tables",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Tables",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_RestaurantId",
                table: "Tables",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Restaurants_RestaurantId",
                table: "Tables",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id");
        }
    }
}
