using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_CodeDeveloper_24.Migrations
{
    /// <inheritdoc />
    public partial class removeriddatabelareceitaingrediente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceitaIngredientes",
                table: "ReceitaIngredientes");

            migrationBuilder.DropIndex(
                name: "IX_ReceitaIngredientes_IngredientesId",
                table: "ReceitaIngredientes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ReceitaIngredientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceitaIngredientes",
                table: "ReceitaIngredientes",
                columns: new[] { "IngredientesId", "ReceitasId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceitaIngredientes",
                table: "ReceitaIngredientes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ReceitaIngredientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceitaIngredientes",
                table: "ReceitaIngredientes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_IngredientesId",
                table: "ReceitaIngredientes",
                column: "IngredientesId");
        }
    }
}
