using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class varchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Instrucciones",
                table: "Recetas",
                type: "varchar (100)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Recetas",
                type: "varchar (100)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Instrucciones",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (100)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (100)",
                oldMaxLength: 50);
        }
    }
}
