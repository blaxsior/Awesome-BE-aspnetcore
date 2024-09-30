using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace renewcs.Migrations
{
    /// <inheritdoc />
    public partial class RemainEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    event_frame_id = table.Column<long>(type: "bigint", nullable: false),
                    event_user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_EventFrames_event_frame_id",
                        column: x => x.event_frame_id,
                        principalTable: "EventFrames",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EventUsers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: " varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    event_frame_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK_EventUsers_EventFrames_event_frame_id",
                        column: x => x.event_frame_id,
                        principalTable: "EventFrames",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShortUrls",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    hash = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    original_url = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortUrls", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrawEventParticipationInfos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    draw_event_id = table.Column<long>(type: "bigint", nullable: false),
                    event_user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawEventParticipationInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrawEventParticipationInfos_DrawEvents_draw_event_id",
                        column: x => x.draw_event_id,
                        principalTable: "DrawEvents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrawEventParticipationInfos_EventUsers_event_user_id",
                        column: x => x.event_user_id,
                        principalTable: "EventUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DrawEventWinningInfos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ranking = table.Column<int>(type: "int", nullable: false),
                    draw_event_id = table.Column<long>(type: "bigint", nullable: false),
                    event_user_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawEventWinningInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_DrawEventWinningInfos_DrawEvents_draw_event_id",
                        column: x => x.draw_event_id,
                        principalTable: "DrawEvents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrawEventWinningInfos_EventUsers_event_user_id",
                        column: x => x.event_user_id,
                        principalTable: "EventUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FcfsEventWinningInfos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    event_user_id = table.Column<long>(type: "bigint", nullable: false),
                    fcfs_event_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FcfsEventWinningInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_FcfsEventWinningInfos_EventUsers_event_user_id",
                        column: x => x.event_user_id,
                        principalTable: "EventUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FcfsEventWinningInfos_FcfsEvents_fcfs_event_id",
                        column: x => x.fcfs_event_id,
                        principalTable: "FcfsEvents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_event_frame_id",
                table: "Comments",
                column: "event_frame_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawEventParticipationInfos_draw_event_id",
                table: "DrawEventParticipationInfos",
                column: "draw_event_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawEventParticipationInfos_event_user_id",
                table: "DrawEventParticipationInfos",
                column: "event_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawEventWinningInfos_draw_event_id",
                table: "DrawEventWinningInfos",
                column: "draw_event_id");

            migrationBuilder.CreateIndex(
                name: "IX_DrawEventWinningInfos_event_user_id",
                table: "DrawEventWinningInfos",
                column: "event_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_event_frame_id",
                table: "EventUsers",
                column: "event_frame_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_user_id",
                table: "EventUsers",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FcfsEventWinningInfos_event_user_id",
                table: "FcfsEventWinningInfos",
                column: "event_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_FcfsEventWinningInfos_fcfs_event_id",
                table: "FcfsEventWinningInfos",
                column: "fcfs_event_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DrawEventParticipationInfos");

            migrationBuilder.DropTable(
                name: "DrawEventWinningInfos");

            migrationBuilder.DropTable(
                name: "FcfsEventWinningInfos");

            migrationBuilder.DropTable(
                name: "ShortUrls");

            migrationBuilder.DropTable(
                name: "EventUsers");
        }
    }
}
