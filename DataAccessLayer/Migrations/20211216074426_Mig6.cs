using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationTypeSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "Takims",
                columns: table => new
                {
                    TakimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takims", x => x.TakimId);
                });

            migrationBuilder.CreateTable(
                name: "Macs",
                columns: table => new
                {
                    MacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MacTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stadyum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvTakimId = table.Column<int>(type: "int", nullable: true),
                    KonukTakimId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macs", x => x.MacId);
                    table.ForeignKey(
                        name: "FK_Macs_Takims_EvTakimId",
                        column: x => x.EvTakimId,
                        principalTable: "Takims",
                        principalColumn: "TakimId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Macs_Takims_KonukTakimId",
                        column: x => x.KonukTakimId,
                        principalTable: "Takims",
                        principalColumn: "TakimId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Macs_EvTakimId",
                table: "Macs",
                column: "EvTakimId");

            migrationBuilder.CreateIndex(
                name: "IX_Macs_KonukTakimId",
                table: "Macs",
                column: "KonukTakimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Macs");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Takims");
        }
    }
}
