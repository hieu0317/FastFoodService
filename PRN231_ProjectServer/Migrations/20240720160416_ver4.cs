using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRN231_ProjectMain.Migrations
{
    public partial class ver4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "CartDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "CartDetails",
                type: "bit",
                nullable: true);
        }
    }
}
