using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace renewcs.Migrations
{
    /// <inheritdoc />
    public partial class Init_Core_Events : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventFrames",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventFrames", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventMetadatas",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    start_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    name = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    event_id = table.Column<string>(type: "varchar(14)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    url = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    event_type = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    event_frame_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventMetadatas", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventMetadatas_EventFrames_event_frame_id",
                        column: x => x.event_frame_id,
                        principalTable: "EventFrames",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrawEvents",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    is_drawn = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    event_metadata_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawEvents", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrawEvents_EventMetadatas_event_metadata_id",
                        column: x => x.event_metadata_id,
                        principalTable: "EventMetadatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FcfsEvents",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    participant_count = table.Column<int>(type: "int", nullable: false),
                    start_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    event_metadata_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FcfsEvents", x => x.id);
                    table.ForeignKey(
                        name: "FK_FcfsEvents_EventMetadatas_event_metadata_id",
                        column: x => x.event_metadata_id,
                        principalTable: "EventMetadatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrawEventMetadatas",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    grade = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    prize_info = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    draw_event_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawEventMetadatas", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrawEventMetadatas_DrawEvents_draw_event_id",
                        column: x => x.draw_event_id,
                        principalTable: "DrawEvents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrawEventScorePolicies",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    action = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    score = table.Column<int>(type: "int", nullable: false),
                    draw_event_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawEventScorePolicies", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrawEventScorePolicies_DrawEvents_draw_event_id",
                        column: x => x.draw_event_id,
                        principalTable: "DrawEvents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DrawEventMetadatas_draw_event_id",
                table: "DrawEventMetadatas",
                column: "draw_event_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawEvents_event_metadata_id",
                table: "DrawEvents",
                column: "event_metadata_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DrawEventScorePolicies_draw_event_id",
                table: "DrawEventScorePolicies",
                column: "draw_event_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventFrames_name",
                table: "EventFrames",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventMetadatas_event_frame_id",
                table: "EventMetadatas",
                column: "event_frame_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventMetadatas_event_id",
                table: "EventMetadatas",
                column: "event_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FcfsEvents_event_metadata_id",
                table: "FcfsEvents",
                column: "event_metadata_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrawEventMetadatas");

            migrationBuilder.DropTable(
                name: "DrawEventScorePolicies");

            migrationBuilder.DropTable(
                name: "FcfsEvents");

            migrationBuilder.DropTable(
                name: "DrawEvents");

            migrationBuilder.DropTable(
                name: "EventMetadatas");

            migrationBuilder.DropTable(
                name: "EventFrames");
        }
    }
}
