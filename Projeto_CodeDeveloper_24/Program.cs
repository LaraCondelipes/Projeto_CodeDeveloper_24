using Microsoft.EntityFrameworkCore.Metadata.Internal;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjetoDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ProjetoDbContext") ?? throw new InvalidOperationException("Connection string 'ProjetoDbContext' not found.")));

//Add services to the container.

builder.Services.AddDbContext<ProjetoDbContext>(options =>
{
    options.UseSqlite("Data Source=(LocalDB)\\MSSQLLocalDB;Database=Receitas;Integrated Security=sspi;");
    
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
