using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Interfaces.Repository;
using MovieShop.Core.Interfaces.Services;
using MovieShop.Infrastructure.Data;
using MovieShop.Infrastructure.Repository;
using MovieShop.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieShopDb"));
});

builder.Services.AddScoped<IMovieServices, MovieService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();