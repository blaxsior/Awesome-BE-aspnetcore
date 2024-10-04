using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace renewcs.Migrations
{
    /// <inheritdoc />
    public partial class Fcfs_Add_PrizeInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "prize_info",
                table: "FcfsEvents",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prize_info",
                table: "FcfsEvents");
        }
    }
}
