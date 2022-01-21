using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A3_HT3610.Migrations
{
    public partial class AuditsContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditType",
                columns: table => new
                {
                    AuditTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditType", x => x.AuditTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    AuditId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AuditTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_Audit_AuditType_AuditTypeId",
                        column: x => x.AuditTypeId,
                        principalTable: "AuditType",
                        principalColumn: "AuditTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AuditType",
                columns: new[] { "AuditTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Cash In" },
                    { 2, "Cash Out" },
                    { 3, "Win" },
                    { 4, "Lose" }
                });

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "AuditId", "Amount", "AuditTypeId", "CreatedDate", "PlayerName" },
                values: new object[,]
                {
                    { 1, 5000.0, 1, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart" },
                    { 4, 1000.0, 1, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian" },
                    { 2, 2000.0, 2, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart" },
                    { 3, 2000.0, 3, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart" },
                    { 5, 0.0, 4, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brian" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Audit_AuditTypeId",
                table: "Audit",
                column: "AuditTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit");

            migrationBuilder.DropTable(
                name: "AuditType");
        }
    }
}
