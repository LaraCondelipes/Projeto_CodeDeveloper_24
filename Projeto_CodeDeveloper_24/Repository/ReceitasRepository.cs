using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;

namespace Projeto_CodeDeveloper_24.Repository
{
    public class ReceitasRepository : IRepository<Receitas>
    {
        private readonly ProjetoDbContext context;
        public ReceitasRepository(ProjetoDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Receitas> GetAll() 
        {
            return context
                .Receitas
                .Include(x => x.ReceitaIngredientes)
                .ToList();
        }

        public Receitas? Get(int id) 
        {
            return context
                .Receitas
                .Include(x => x.ReceitaIngredientes)
                .FirstOrDefault(x => x.Id == id);
        }

        public Receitas? Add(Receitas value)
        {
            context.Receitas.Add(value);
            context.SaveChanges();

            return value;   
        }
        public void Update(Receitas value) 
        {
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id) 
        {
            var Receitas = Get(id);
            if (Receitas != null) 
            {
                context.Receitas.Remove(Receitas);
                context.SaveChanges();  
            }

        }

        public IEnumerable<Receitas> All()
        {
            throw new NotImplementedException();
        }
    }
}
