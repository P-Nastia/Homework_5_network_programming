using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NovaPoshta.Migrations
{
    /// <inheritdoc />
    public partial class Add_tbl_warehouses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DimensionsEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionsEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkScheduleEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Monday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Tuesday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Wednesday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Thursday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Friday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Saturday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Sunday = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkScheduleEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SiteKey = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    ShortAddress = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    TypeOfWarehouse = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Ref = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Number = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CityRef = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CityDescription = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SettlementRef = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SettlementDescription = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SettlementAreaDescription = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SettlementRegionsDescription = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SettlementTypeDescription = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Longitude = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Latitude = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PostFinance = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    BicycleParking = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PaymentAccess = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    POSTerminal = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    InternationalShipping = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SelfServiceWorkplacesCount = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    TotalMaxWeightAllowed = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PlaceMaxWeightAllowed = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SendingLimitationsOnDimensionsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceivingLimitationsOnDimensionsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    DeliveryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ScheduleId = table.Column<int>(type: "INTEGER", nullable: false),
                    DistrictCode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    WarehouseStatus = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    WarehouseStatusDate = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    WarehouseIllusha = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CategoryOfWarehouse = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Direct = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    RegionCity = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    WarehouseForAgent = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    GeneratorEnabled = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    MaxDeclaredCost = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    WorkInMobileAwis = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    DenyToSelect = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CanGetMoneyTransfer = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    HasMirror = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    HasFittingRoom = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    OnlyReceivingParcel = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PostMachineType = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PostalCodeUA = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    WarehouseIndex = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    BeaconCode = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    PostomatFor = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_warehouses_DimensionsEntity_ReceivingLimitationsOnDimensionsId",
                        column: x => x.ReceivingLimitationsOnDimensionsId,
                        principalTable: "DimensionsEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_warehouses_DimensionsEntity_SendingLimitationsOnDimensionsId",
                        column: x => x.SendingLimitationsOnDimensionsId,
                        principalTable: "DimensionsEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_warehouses_WorkScheduleEntity_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "WorkScheduleEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_warehouses_WorkScheduleEntity_ReceptionId",
                        column: x => x.ReceptionId,
                        principalTable: "WorkScheduleEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_warehouses_WorkScheduleEntity_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "WorkScheduleEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_warehouses_tbl_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "tbl_cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_warehouses_CityId",
                table: "tbl_warehouses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_warehouses_DeliveryId",
                table: "tbl_warehouses",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_warehouses_ReceivingLimitationsOnDimensionsId",
                table: "tbl_warehouses",
                column: "ReceivingLimitationsOnDimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_warehouses_ReceptionId",
                table: "tbl_warehouses",
                column: "ReceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_warehouses_ScheduleId",
                table: "tbl_warehouses",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_warehouses_SendingLimitationsOnDimensionsId",
                table: "tbl_warehouses",
                column: "SendingLimitationsOnDimensionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_warehouses");

            migrationBuilder.DropTable(
                name: "DimensionsEntity");

            migrationBuilder.DropTable(
                name: "WorkScheduleEntity");
        }
    }
}
