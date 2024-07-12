using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Projeto_CodeDeveloper_24.Models
{
    //[PrimaryKey(nameof(ReceitasId), nameof(IngredientesId))]
    public class ReceitaIngredientes
    {
        //public int? Id { get; set; }
        public int? ReceitasId { get; set; } //FK
        [JsonIgnore]
        //public List<Receitas>? Receitas { get; set; } = null!;
        public virtual Receitas? Receitas { get; set; } 
      
        public string? Unidades { get; set; }
        public double? Quantidade { get; set; }
        [Key]
        public int? IngredientesId { get; set; } //FK

        //public List<Ingredientes>? Ingredientes { get; set; } = null!;
        [JsonIgnore]
        public virtual Ingredientes? Ingredientes { get; set; } 
   
    }
}
