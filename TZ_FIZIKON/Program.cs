using TZ_FIZIKON.Interface;
using TZ_FIZIKON.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddCors(opions =>
{
    opions.AddPolicy(name: "CorsPolicy", policy =>
    {
        policy.AllowAnyOrigin();
    });
});

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddTransient<IRepository, Repository>(provider => new Repository(connection));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Client}/{action=Index}");

app.Run();
