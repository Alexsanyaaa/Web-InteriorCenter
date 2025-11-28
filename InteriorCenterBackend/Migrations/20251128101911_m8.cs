using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteriorCenterBackend.Migrations
{
    /// <inheritdoc />
    public partial class m8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Picture",
                newName: "ImageUrL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrL",
                table: "Picture",
                newName: "ImageUrl");
        }
    }
}
