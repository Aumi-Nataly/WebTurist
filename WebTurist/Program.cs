using DataBaseLib.TuristDB.Models;
using Microsoft.EntityFrameworkCore;
using WebTurist.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

#region My services
var connectionString = builder.Configuration.GetConnectionString("TuristDB");
builder.Services.AddDbContext<TuristDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<Contract.ICountryCity, ServiceData.CountryCity>();

builder.Services.AddScoped<PageHaveCountryAtribute>();

#endregion





var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseStatusCodePagesWithReExecute("/StatusCode/{0}");
app.UseExceptionHandler("/Error");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
