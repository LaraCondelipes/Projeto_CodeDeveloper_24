using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_CodeDeveloper_24.Migrations
{
    /// <inheritdoc />
    public partial class adicionarosidscomnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                table: "ReceitaIngredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaIngredientes_Receitas_ReceitasId",
                table: "ReceitaIngredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categorias_CategoriasId",
                table: "Receitas");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriasId",
                table: "Receitas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ReceitasId",
                table: "ReceitaIngredientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IngredientesId",
                table: "ReceitaIngredientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                table: "ReceitaIngredientes",
                column: "IngredientesId",
                principalTable: "Ingredientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReceitaIngredientes_Receitas_ReceitasId",
                table: "ReceitaIngredientes",
                column: "ReceitasId",
                principalTable: "Receitas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categorias_CategoriasId",
                table: "Receitas",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                table: "ReceitaIngredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaIngredientes_Receitas_ReceitasId",
                table: "ReceitaIngredientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categorias_CategoriasId",
                table: "Receitas");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriasId",
                table: "Receitas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReceitasId",
                table: "ReceitaIngredientes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "IngredientesId",
                table: "ReceitaIngredientes",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                table: "ReceitaIngredientes",
                column: "IngredientesId",
                principalTable: "Ingredientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceitaIngredientes_Receitas_ReceitasId",
                table: "ReceitaIngredientes",
                column: "ReceitasId",
                principalTable: "Receitas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categorias_CategoriasId",
                table: "Receitas",
                column: "CategoriasId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
