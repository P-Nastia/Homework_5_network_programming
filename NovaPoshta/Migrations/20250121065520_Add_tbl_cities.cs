using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPoshta.Migrations
{
    /// <inheritdoc />
    public partial class Add_tbl_cities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ref = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery1 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery2 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery3 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery4 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery5 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery6 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Delivery7 = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Area = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    SettlementType = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    IsBranch = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    PreventEntryNewStreetsUser = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    CityID = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    SettlementTypeDescription = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    SpecialCashCheck = table.Column<int>(type: "INTEGER", nullable: false),
                    AreaDescription = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    AreaEntityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_cities_tbl_areas_AreaEntityId",
                        column: x => x.AreaEntityId,
                        principalTable: "tbl_areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_cities_AreaEntityId",
                table: "tbl_cities",
                column: "AreaEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_cities");
        }
    }
}
