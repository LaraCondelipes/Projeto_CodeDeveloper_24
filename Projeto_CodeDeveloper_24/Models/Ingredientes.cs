namespace Projeto_CodeDeveloper_24.Models
{
    public class Ingredientes
    {
        public int IngredientesId { get; set; }
        public string? IngredienteName { get; set; }
        public List<ReceitaIngredientes>? ReceitaIngredientes { get; set; } = [];
        public int Id { get; internal set; }
    }
}
