using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    public class Receitas
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int? Duracao { get; set; }

        public string? Dificuldade { get; set; }
        public string? Descricao { get; set; }
        

        // public List<Ingredientes>? Ingredientes { get; } = [];  //FK
        public List<ReceitaIngredientes>? ReceitaIngredientes { get; set; } = [];

        public int CategoriasId { get; set; }

        [JsonIgnore] public Categorias? Categorias { get; set; }
    }
}
