using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    public class ReceitaIngredientes
    {
        public int Id { get; set; }
        [JsonIgnore] 
        public List<Receitas>? Receitas { get; set; }
        public string? Unidades { get; set; }
        public double? Quantidade { get; set; }
        public Ingredientes? Ingredientes { get; set; }
    }
}
