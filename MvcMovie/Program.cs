using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Si deseas agregar rutas adicionales, simplemente agrega m�s llamadas al m�todo MapControllerRoute antes del app.Run(). 

//app.MapControllerRoute(
//	name: "helloWorld",
//	pattern: "HelloWorld",
//	defaults: new { controller = "HelloWorld", action = "Index" });

//app.MapControllerRoute(
//	name: "otherRoute",
//	pattern: "OtherRoute",
//	defaults: new { controller = "Other", action = "OtherAction" });

// Ruta predeterminada

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
