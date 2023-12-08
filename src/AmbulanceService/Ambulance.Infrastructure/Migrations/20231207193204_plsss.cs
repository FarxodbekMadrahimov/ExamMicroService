using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambulance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class plsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "amulanceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_amulanceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "emergencyCalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeOfCall = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmbulanceDispatched = table.Column<bool>(type: "bit", nullable: false),
                    AmbulanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emergencyCalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emergencyCalls_amulanceInfo_AmbulanceId",
                        column: x => x.AmbulanceId,
                        principalTable: "amulanceInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyCallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_doctors_emergencyCalls_EmergencyCallId",
                        column: x => x.EmergencyCallId,
                        principalTable: "emergencyCalls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    EmergencyCallId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patients_emergencyCalls_EmergencyCallId",
                        column: x => x.EmergencyCallId,
                        principalTable: "emergencyCalls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_doctors_EmergencyCallId",
                table: "doctors",
                column: "EmergencyCallId");

            migrationBuilder.CreateIndex(
                name: "IX_emergencyCalls_AmbulanceId",
                table: "emergencyCalls",
                column: "AmbulanceId");

            migrationBuilder.CreateIndex(
                name: "IX_patients_EmergencyCallId",
                table: "patients",
                column: "EmergencyCallId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "emergencyCalls");

            migrationBuilder.DropTable(
                name: "amulanceInfo");
        }
    }
}
