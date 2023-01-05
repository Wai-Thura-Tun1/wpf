using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfOJT.Entities.Migrations
{
    /// <inheritdoc />
    public partial class postdbupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Post");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Post",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
