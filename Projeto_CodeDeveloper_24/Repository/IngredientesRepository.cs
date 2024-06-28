using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;

namespace Projeto_CodeDeveloper_24.Repository
{
    public class IngredientesRepository : IRepository<Ingredientes>
    {
        private readonly ProjetoDbContext Context;

        public IngredientesRepository(ProjetoDbContext context) 
        { 
            this.Context = context;
        }

        public IEnumerable<Ingredientes> GetAll() 
        {
            return Context
                .Ingredientes
                .Include(x => x.ReceitaIngredientes)
                .ToList();
        }
        public Ingredientes? Get(int id) 
        {
            return Context
                .Ingredientes   
                .Include(x => x.ReceitaIngredientes)
                .FirstOrDefault(x => x.Id == id);
        }
        public Ingredientes Add(Ingredientes value) 
        {
            Context.Ingredientes.Add(value);
            Context.SaveChanges();

            return value;
        }
        public void Update(Ingredientes value) 
        {
            Context.Entry(value).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }

        public void Delete(int id) 
        {
            var value = Get(id);
            if (value != null)
            { 
                Context.Ingredientes.Remove(value);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Ingredientes> All()
        {
            throw new NotImplementedException();
        }
    }
}
