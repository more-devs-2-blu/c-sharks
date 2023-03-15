using CSharks.NFEs.Domain.Interfaces.Repositories;
using CSharks.NFEs.Infra.Data.Data;
using CSharks.NFEs.Infra.Data.Repositories;
using CSharks.NFEs.Services;
using CSharks.NFEs.Services.Interfaces;
using CSharks.NFEs.Services.Services;
using CSharks.NFEs.WebApp.Services;
using Microsoft.EntityFrameworkCore;

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
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IExcel, ExcelService>();
builder.Services.AddScoped<ICacheMemory, CacheMemory>();

builder.Services.AddScoped<IApiClientService, ApiClient>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
builder.Services.AddScoped<IServicesRepository, ServicesRepository>();
builder.Services.AddScoped<IIsqnRepository, IsqnRepository>();

//NF Utils
builder.Services.AddScoped<IEnterpriseRepository, EnterpriseRepository>();
builder.Services.AddScoped<IEmitedNfRepository, EmitedNfRepository>();  

builder.Services.AddHttpClient<IDataProviderService, DataProviderClient>(client =>
{
    //lient.BaseAddress = new Uri("");
    client.BaseAddress = new Uri("http://localhost:8080/");
});

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
