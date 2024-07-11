using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;
using Projeto_CodeDeveloper_24.Repository;

public class CategoriasRepository : IRepository<Categorias>
{
    private readonly ProjetoDbContext context;

    public CategoriasRepository(ProjetoDbContext context)
    {
        this.context = context;
    }

    public IEnumerable<Categorias> GetAll()
    {
        return context
            .Categorias
            .Include(b => b.Receitas)
            .ToList();
    }

    public Categorias? Get(int id)
    {
        return context
            .Categorias
            .Include(b => b.Receitas)
            .FirstOrDefault(b => b.Id == id);
    }

    public Categorias Add(Categorias value)
    {
        context.Categorias.Add(value);
        context.SaveChanges();

        return value;
    }

    public void Update(Categorias value)
    {
        context.Entry(value).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        var value = Get(id);

        if (value != null)
        {
            context.Categorias.Remove(value);
            context.SaveChanges();
        }
    }

    IEnumerable<Categorias> IRepository<Categorias>.All()
    {
        throw new NotImplementedException();
    }

   
}