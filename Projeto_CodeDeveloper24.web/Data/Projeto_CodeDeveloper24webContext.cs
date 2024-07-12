using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_CodeDeveloper_24.Models;

namespace Projeto_CodeDeveloper24.web.Data
{
    public class Projeto_CodeDeveloper24webContext : DbContext
    {
        public Projeto_CodeDeveloper24webContext (DbContextOptions<Projeto_CodeDeveloper24webContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_CodeDeveloper_24.Models.Receitas> Receitas { get; set; } = default!;
    }
}
