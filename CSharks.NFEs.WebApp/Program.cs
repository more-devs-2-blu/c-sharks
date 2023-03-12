using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Domain.Interfaces.Repositories.NF_UTILS;
using CSharks.NFEs.Domain.Models;
using CSharks.NFEs.Infra.Data.Data;
using CSharks.NFEs.Infra.Data.Repositories;
using CSharks.NFEs.Infra.Data.Repositories.NF_UTILS;
using CSharks.NFEs.Services.Interfaces;
using CSharks.NFEs.Services.Services;
using CSharks.NFEs.WebApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
var MySqlConnectionString = builder.Configuration.GetConnectionString("MySqlConnectionString");



// Add services to the container.
//Extensions services
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<MySqlContext>
    (options => options.UseMySql(MySqlConnectionString, ServerVersion.AutoDetect(MySqlConnectionString)));

//Default lifetimes services
builder.Services.AddScoped<ISessionService, UserSession>();

builder.Services.AddScoped<IApiClientService, ApiClient>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
builder.Services.AddScoped<IServicesRepository, ServicesRepository>();

//NF Utils
builder.Services.AddScoped<INFRepository, NFRepository>();
builder.Services.AddScoped<IListaRepository, ListaRepository>();
builder.Services.AddScoped<IPesquisaRepository, PesquisaRepository>();
builder.Services.AddScoped<ITomadorRepository, TomadorRepository>();
builder.Services.AddScoped<IPrestadorRepository, PrestadorRepository>();


//Creates WebApplication instance

var app = builder.Build();

//Resources
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}");

//Run migration
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<MySqlContext>();
    if (context.Database.GetPendingMigrations().Any())
    {
        context.Database.Migrate();
    }
}

app.Run();
