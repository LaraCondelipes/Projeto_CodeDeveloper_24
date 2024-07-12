using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    public class Ingredientes
    {
        public int? Id { get; set; }
        public string? IngredienteName { get; set; }
        [JsonIgnore]
        public virtual List<ReceitaIngredientes>? ReceitaIngredientes { get; set; } = [];  //FK
        
    }
}
