using Client_Server_TTT_;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Data.SQLite;

var builder = WebApplication.CreateBuilder(args);

string databasePath = "Data\\clientserver_ttt.db";
var dataService = new SqliteDataService(databasePath);
 
builder.Services.AddSingleton(dataService);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
} 

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapHub<SignlaR.Hubs.ChatHub>("/chathub");

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


