using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace renewcs.Migrations
{
    /// <inheritdoc />
    public partial class EventFrame_FrameId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EventFrames_name",
                table: "EventFrames");

            migrationBuilder.DropColumn(
                name: "description",
                table: "EventFrames");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "EventFrames",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FrameId",
                table: "EventFrames",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EventFrames_FrameId",
                table: "EventFrames",
                column: "FrameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EventFrames_FrameId",
                table: "EventFrames");

            migrationBuilder.DropColumn(
                name: "FrameId",
                table: "EventFrames");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "EventFrames",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "EventFrames",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EventFrames_name",
                table: "EventFrames",
                column: "name",
                unique: true);
        }
    }
}
