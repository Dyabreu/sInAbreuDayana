using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class extra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Recetas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categoria",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
