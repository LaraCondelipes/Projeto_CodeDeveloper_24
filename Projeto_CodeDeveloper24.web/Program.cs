using Projeto_CodeDeveloper24.web.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projeto_CodeDeveloper24.web.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<Projeto_CodeDeveloper24webContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Projeto_CodeDeveloper24webContext") ?? throw new InvalidOperationException("Connection string 'Projeto_CodeDeveloper24webContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddHttpClient();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
