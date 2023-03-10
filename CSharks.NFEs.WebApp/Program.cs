using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

/*
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer();
*/

// Add services to the container.


var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}");
app.Run();
