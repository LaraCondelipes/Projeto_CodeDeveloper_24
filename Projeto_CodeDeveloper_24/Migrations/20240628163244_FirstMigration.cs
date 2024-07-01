using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_CodeDeveloper_24.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IngredientesId = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredienteName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Duracao = table.Column<int>(type: "INTEGER", nullable: true),
                    Dificuldade = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaIngredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Unidades = table.Column<string>(type: "TEXT", nullable: true),
                    Quantidade = table.Column<double>(type: "REAL", nullable: true),
                    IngredientesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaIngredientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientes_Ingredientes_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReceitaIngredientesReceitas",
                columns: table => new
                {
                    ReceitaIngredientesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceitasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaIngredientesReceitas", x => new { x.ReceitaIngredientesId, x.ReceitasId });
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientesReceitas_ReceitaIngredientes_ReceitaIngredientesId",
                        column: x => x.ReceitaIngredientesId,
                        principalTable: "ReceitaIngredientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientesReceitas_Receitas_ReceitasId",
                        column: x => x.ReceitasId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_IngredientesId",
                table: "ReceitaIngredientes",
                column: "IngredientesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientesReceitas_ReceitasId",
                table: "ReceitaIngredientesReceitas",
                column: "ReceitasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceitaIngredientesReceitas");

            migrationBuilder.DropTable(
                name: "ReceitaIngredientes");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "Ingredientes");
        }
    }
}
