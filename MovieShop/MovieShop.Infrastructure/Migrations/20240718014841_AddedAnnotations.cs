using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Budget",
                table: "Movies",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 2084,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Budget",
                table: "Movies",
                type: "decimal(18,2)",
                maxLength: 2084,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);
        }
    }
}
