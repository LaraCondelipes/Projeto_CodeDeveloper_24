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

        public DbSet<Ingredientes> Ingredientes { get; set; } = default!;

public DbSet<ReceitaIngredientes> ReceitaIngredientes { get; set; } = default!;

public DbSet<Receitas> Receitas { get; set; } = default!;
    public DbSet<Categorias> Categorias { get; set; } = default!;


    //fazer a ralação das tabelas
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Ingredientes>()
//   .HasMany(e => e.Receitas)
//   .WithMany(e => e.Ingredientes)
//   .UsingEntity<ReceitaIngredientes>(
//       l => l.HasOne<Receitas>().WithMany().HasForeignKey(e => e.ReceitasId),
//       r => r.HasOne<Ingredientes>().WithMany().HasForeignKey(e => e.IngredientesId));


//    modelBuilder.Entity<Receitas>()
//   .HasMany(e => e.Ingredientes)
//   .WithMany(e => e.Receitas)
//   .UsingEntity<ReceitaIngredientes>(
//       l => l.HasOne<Ingredientes>().WithMany().HasForeignKey(e => e.IngredientesId),
//       r => r.HasOne<Receitas>().WithMany().HasForeignKey(e => e.ReceitasId));

//}
   
//    // modelBuilder.Entity<Categorias>()
//    //{
       
//    //        .HasOne(e => e.Categorias).WithMany(e. => e)
//    //        .WithMany(c => c.Receitas)
//    //        .HasForeignKey(r => r.CategoriasId);
//    //}
}
