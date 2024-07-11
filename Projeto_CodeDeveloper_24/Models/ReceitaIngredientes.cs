using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    public class ReceitaIngredientes
    {
        public int Id { get; set; }
        //public int ReceitasId { get; set; } //FK
        [JsonIgnore]
        //public List<Receitas>? Receitas { get; set; } = null!;
        public Receitas? Receitas { get; set; } 
      
        public string? Unidades { get; set; }
        public double? Quantidade { get; set; }
       // public int IngredientesId { get; set; } //FK
        
        //public List<Ingredientes>? Ingredientes { get; set; } = null!;
        public Ingredientes? Ingredientes { get; set; } 
   
    }
}
