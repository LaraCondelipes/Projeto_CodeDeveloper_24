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
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    CategoriasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receitas_Categorias_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaIngredientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReceitasId = table.Column<int>(type: "INTEGER", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_ReceitaIngredientes_Receitas_ReceitasId",
                        column: x => x.ReceitasId,
                        principalTable: "Receitas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_IngredientesId",
                table: "ReceitaIngredientes",
                column: "IngredientesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitaIngredientes_ReceitasId",
                table: "ReceitaIngredientes",
                column: "ReceitasId");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_CategoriasId",
                table: "Receitas",
                column: "CategoriasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceitaIngredientes");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
