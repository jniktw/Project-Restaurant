using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantSystem.DataAcessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelTORelationMN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantTable");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Tables",
                type: "INTEGER",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Restaurants_RestaurantId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_RestaurantId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Tables");

            migrationBuilder.CreateTable(
                name: "RestaurantTable",
                columns: table => new
                {
                    RestaurantsId = table.Column<int>(type: "INTEGER", nullable: false),
                    TablesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantTable", x => new { x.RestaurantsId, x.TablesId });
                    table.ForeignKey(
                        name: "FK_RestaurantTable_Restaurants_RestaurantsId",
                        column: x => x.RestaurantsId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantTable_Tables_TablesId",
                        column: x => x.TablesId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantTable_TablesId",
                table: "RestaurantTable",
                column: "TablesId");
        }
    }
}
