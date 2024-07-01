using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    public class Receitas
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int? Duracao { get; set; }
        
        public List<ReceitaIngredientes>? ReceitaIngredientes { get; set; }
        public string? Dificuldade { get; set; }
        public string? Descricao { get; set; }
        public string? Categoria { get; set; }
    }
}
