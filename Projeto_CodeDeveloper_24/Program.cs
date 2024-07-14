using Microsoft.EntityFrameworkCore.Metadata.Internal;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projeto_CodeDeveloper_24.Repository;
using Projeto_CodeDeveloper_24.Models;



//Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjetoDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ProjetoDbContext") ?? throw new InvalidOperationException("Connection string 'ProjetoDbContext' not found.")));

//builder.Services.AddDbContext<ProjetoDbContext>(options =>
//{
//    options.UseSqlite("Data Source=(LocalDB)\\MSSQLLocalDB;Database=Receitas;Integrated Security=sspi;");

//});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<Receitas>, ReceitasRepository>();
builder.Services.AddScoped<IRepository<Ingredientes>, IngredientesRepository>();
builder.Services.AddScoped<IRepository<Categorias>, CategoriasRepository>();
builder.Services.AddScoped<IRepository<ReceitaIngredientes>, ReceitaIngredientesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
