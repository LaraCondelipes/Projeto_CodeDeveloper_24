using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;

    public class ProjetoDbContext : DbContext
    {
        public ProjetoDbContext (DbContextOptions<ProjetoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_CodeDeveloper_24.Models.Ingredientes> Ingredientes { get; set; } = default!;

public DbSet<Projeto_CodeDeveloper_24.Models.ReceitaIngredientes> ReceitaIngredientes { get; set; } = default!;

public DbSet<Projeto_CodeDeveloper_24.Models.Receitas> Receitas { get; set; } = default!;
    }
