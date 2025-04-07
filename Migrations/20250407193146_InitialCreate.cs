using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentMeetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeetingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConductingLeader = table.Column<string>(type: "TEXT", nullable: false),
                    OpeningSong = table.Column<string>(type: "TEXT", nullable: false),
                    SacramentHymn = table.Column<string>(type: "TEXT", nullable: false),
                    ClosingSong = table.Column<string>(type: "TEXT", nullable: false),
                    IntermediateMusicalNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OpeningPrayer = table.Column<string>(type: "TEXT", nullable: false),
                    ClosingPrayer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeetings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: false),
                    SacramentMeetingId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speakers_SacramentMeetings_SacramentMeetingId",
                        column: x => x.SacramentMeetingId,
                        principalTable: "SacramentMeetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_SacramentMeetingId",
                table: "Speakers",
                column: "SacramentMeetingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "SacramentMeetings");
        }
    }
}
