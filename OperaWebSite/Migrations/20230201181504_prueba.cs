using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebMisRecetas.Migrations
{
    public partial class prueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Recetas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instrucciones",
                table: "Recetas",
                type: "varchar (50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Instrucciones",
                table: "Recetas");

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Recetas",
                type: "varchar (200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar (50)",
                oldMaxLength: 50);
        }
    }
}
