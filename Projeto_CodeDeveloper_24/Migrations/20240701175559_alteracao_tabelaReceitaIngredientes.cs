using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_CodeDeveloper_24.Migrations
{
    /// <inheritdoc />
    public partial class alteracao_tabelaReceitaIngredientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                table: "ReceitaIngredientes");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                table: "ReceitaIngredientes");

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
        }
    }
}
