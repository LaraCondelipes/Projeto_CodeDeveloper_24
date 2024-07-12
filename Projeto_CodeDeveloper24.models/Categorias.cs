using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    public class Categorias
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
      
        [JsonIgnore]
        public virtual List<Receitas>? Receitas { get; set; } = [];  //FK
    }
}
